# خطوات رفع المشروع إلى GitHub

## 1. تأكد من تثبيت Git
إذا لم يكن Git مثبتاً، قم بتحميله من: https://git-scm.com/download/win

## 2. افتح Terminal/PowerShell في مجلد المشروع
```bash
cd "c:\Users\م رهيب\Downloads\rove store\rova-solution"
```

## 3. ابدأ Git Repository
```bash
git init
git add .
git commit -m "Initial commit: Rova solution with Core and Shared projects"
```

## 4. اربط المشروع بـ GitHub

### الطريقة الأولى (إذا كان المستودع موجود):
```bash
git remote add origin https://github.com/waleedsaidi/rove-app.git
git branch -M main
git push -u origin main
```

### الطريقة الثانية (إذا كان المستودع غير موجود):
1. اذهب إلى: https://github.com/new
2. اسم المستودع: `rove-app`
3. اجعله Public أو Private حسب رغبتك
4. **لا تقم** بإضافة README أو .gitignore أو license
5. اضغط "Create repository"
6. ثم شغل الأوامر:
```bash
git remote add origin https://github.com/waleedsaidi/rove-app.git
git branch -M main
git push -u origin main
```

## 5. إذا طلب منك GitHub اسم المستخدم وكلمة المرور
استخدم Personal Access Token بدلاً من كلمة المرور:
1. اذهب إلى: https://github.com/settings/tokens
2. Generate new token (classic)
3. اختر permissions: repo
4. استخدم الـ token كـ password

---

## ✅ الحالة الحالية للمشروع

### المشاريع التي تعمل:
- ✅ **Rova.Core** - المنطق الأساسي والخدمات
- ✅ **Rova.Shared** - النماذج والأنواع المشتركة

### تم إصلاح:
- ترقية من .NET 6.0 → .NET 9.0
- تحديث جميع الحزم
- إصلاح System.ComponentModel.Annotations
- إضافة InventoryItem, AttendanceReportDto, PerformanceReportDto
- إصلاح AuthService, BookingService, ReportingService, InventoryService
- البناء ينجح بدون أخطاء

### قيد التطوير:
- ⏳ Rova.Web (تم استبعاده مؤقتاً - يحتاج إصلاحات إضافية)
- ⏳ Rova.Mobile (تم استبعاده مؤقتاً - يحتاج workloads MAUI)
- ⏳ Rova.Tests (تم استبعاده مؤقتاً - يحتاج تحديثات)
