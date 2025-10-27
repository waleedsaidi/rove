using System.Collections.ObjectModel;
using System.Windows.Input;
using Rova.Mobile.Models;
using Rova.Mobile.Services;

namespace Rova.Mobile.ViewModels
{
    public class DebtsViewModel : BaseViewModel
    {
        private readonly IDebtService _debtService;
        public ObservableCollection<DebtRecord> DebtRecords { get; private set; }

        public DebtsViewModel(IDebtService debtService)
        {
            _debtService = debtService;
            DebtRecords = new ObservableCollection<DebtRecord>();
            LoadDebtRecords();
        }

        private async void LoadDebtRecords()
        {
            var records = await _debtService.GetDebtRecordsAsync();
            foreach (var record in records)
            {
                DebtRecords.Add(record);
            }
        }

        public ICommand PayDebtCommand => new Command<DebtRecord>(async (debtRecord) =>
        {
            if (debtRecord != null)
            {
                await _debtService.PayDebtAsync(debtRecord);
                DebtRecords.Remove(debtRecord);
            }
        });
    }
}