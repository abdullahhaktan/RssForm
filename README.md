# RssForm

[TR]

**Rapi API veya doğrudan RSS Kaynakları ile Haber Okuyucu Windows Form Uygulaması**

[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![GitHub repo size](https://img.shields.io/github/repo-size/abdullahhaktan/RssForm)](https://github.com/abdullahhaktan/RssForm)

---

## 💻 Proje Hakkında

RssForm, popüler Türk haber sitelerinden ve kullanıcı tarafından girilen RSS kaynaklarından güncel haber başlıklarını çeken bir Windows Form uygulamasıdır. Kullanıcı dostu arayüzü ile haberleri listeleme ve görüntüleme işlemlerini kolaylaştırır.

---

## ✨ Temel Özellikler

* **RSS/Haber Çekme İşlevi:** Belirtilen RSS kaynaklarından veri akışı otomatik olarak alınır ve işlenir.
* **Form Tabanlı Arayüz:** Windows Form uygulaması ile haber başlıklarını listeleme ve görsel olarak sunma imkanı.
* **Geliştirme Dili:** Uygulama **C#** ile geliştirilmiştir.
* **Kendi RSS URL’nizi Kullanabilme:** Kullanıcı istediği RSS adresini girerek haberleri görüntüleyebilir.

---

## 🚀 Nasıl Çalıştırılır? 

1. **Projeyi Klonlama:**
    ```bash
    git clone https://github.com/abdullahhaktan/RssForm
    cd RssForm
    ```

2. **Rapi API (Opsiyonel) veya Doğrudan RSS Kullanımı:**
    * Rapi API üzerinden veri çekmek istiyorsanız, bir API anahtarı (X-RapidAPI-Key) alın ve gerekli ayarları `app.config` veya kod içerisindeki sabit değişkene ekleyin.
    * Eğer doğrudan RSS kullanıyorsanız, ek bir API anahtarı gerekmemektedir.

3. **Çözümü Açma:**
    * Kök dizindeki **`RssForm.sln`** dosyasını Visual Studio’da açın.

4. **Derleme ve Çalıştırma:**
    * Çözümü derleyin (`Build Solution` veya **F6**).
    * Projeyi **Startup Project** olarak ayarlayın ve **F5** ile çalıştırın.

---

## 🔹 Kullanım

1. Haber kaynağı butonlarından birini tıklayarak (Hurriyet, Milliyet, Fotomac) ilgili haber başlıkları listelenir.
2. Kendi RSS URL’nizi girmek için metin kutusuna URL’yi yazın ve **Ara** butonuna tıklayın.
3. Listelenen başlıklara tıklayarak detaylarını görüntüleyebilirsiniz (ek özellik eklenirse).

---

## 📸 Ekran Görüntüleri

<img width="895" height="437" alt="Ekran görüntüsü 1" src="https://github.com/user-attachments/assets/ff35d725-ce86-42e8-8734-69e451273307" />
<img width="779" height="421" alt="Ekran görüntüsü 2" src="https://github.com/user-attachments/assets/b8e016c6-debc-4f25-a3dd-d9c64752e9fc" />

---

[EN]

# RssForm

**Windows Form Application for Reading News from RSS Feeds or via Rapi API**

---

## 💻 About the Project

RssForm is a Windows Form application that fetches up-to-date news headlines from popular Turkish news sites or user-provided RSS URLs. It provides an easy-to-use interface for listing and viewing news.

---

## ✨ Core Features

* **RSS/News Fetching:** Automatically retrieves and processes data from specified RSS feeds.
* **Form-Based Interface:** Lists and visually displays news headlines in a Windows Form application.
* **Development Language:** Developed using **C#**.
* **Custom RSS URLs:** Users can enter any RSS URL to fetch news.

---

## 🚀 How to Run

1. **Clone the Project:**
    ```bash
    git clone https://github.com/abdullahhaktan/RssForm
    cd RssForm
    ```

2. **Rapi API (Optional) or Direct RSS Use:**
    * To fetch data via Rapi API, get an API key (X-RapidAPI-Key) and add it to `app.config` or a constant in the code.
    * Direct RSS usage does not require an API key.

3. **Open the Solution:**
    * Open **`RssForm.sln`** in Visual Studio.

4. **Build and Run:**
    * Build the solution (`Build Solution` or **F6**).
    * Set the project as **Startup Project** and press **F5** to run.

---

## 🔹 Usage

1. Click on a news source button (Hurriyet, Milliyet, Fotomac) to list related headlines.
2. Enter your own RSS URL in the text box and click **Search** to fetch news.
3. Click on listed headlines to view details (if additional features are added).

---

## 📸 Screenshots

<img width="895" height="437" alt="Screenshot 1" src="https://github.com/user-attachments/assets/ff35d725-ce86-42e8-8734-69e451273307" />
<img width="779" height="421" alt="Screenshot 2" src="https://github.com/user-attachments/assets/b8e016c6-debc-4f25-a3dd-d9c64752e9fc" />
