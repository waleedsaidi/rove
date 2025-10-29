# 🔍 فحص حالة النشر

## الخطوات للتحقق:

### 1. تحقق من الـ Actions
اذهب إلى: **https://github.com/waleedsaidi/rove/actions**

- هل هناك workflow قيد التشغيل؟
- هل فشل workflow؟
- إذا فشل، ما هو الخطأ؟

---

### 2. تفعيل GitHub Pages يدوياً

#### أ. اذهب إلى Settings:
**https://github.com/waleedsaidi/rove/settings/pages**

#### ب. في قسم "Build and deployment":
- **Source**: اختر **GitHub Actions** (مهم جداً!)

---

### 3. إعطاء صلاحيات للـ Workflow

#### أ. اذهب إلى:
**https://github.com/waleedsaidi/rove/settings/actions**

#### ب. Workflow permissions:
- ✅ اختر: **Read and write permissions**
- ✅ فعّل: **Allow GitHub Actions to create and approve pull requests**
- اضغط **Save**

---

### 4. تشغيل الـ Workflow يدوياً

#### أ. اذهب إلى:
**https://github.com/waleedsaidi/rove/actions**

#### ب. اختر:
- Workflow: **Deploy to GitHub Pages**
- اضغط: **Run workflow**
- Branch: **main**
- اضغط: **Run workflow** (الزر الأخضر)

---

### 5. انتظر وتحقق

بعد 2-3 دقائق:
- تحقق من: **https://github.com/waleedsaidi/rove/actions**
- يجب أن ترى علامة ✅ خضراء
- افتح: **https://waleedsaidi.github.io/rove/**

---

## 🆘 إذا استمرت المشكلة:

أرسل لي لقطة شاشة من:
1. https://github.com/waleedsaidi/rove/actions (صفحة Actions)
2. رسالة الخطأ إن وجدت

وسأساعدك في حلها!
