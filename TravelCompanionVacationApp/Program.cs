bool continuePlanning; // Programın yeniden çalışıp çalışmıyacağının değerini tutacak değişken

do
{
    #region Location

    string location = ""; // Lokasyon bilgisi
    int locationPrice = 0; // Lokasyon tatil paketi fiyatı
    bool isValid1 = false; // While döngüsüne girip çıkmak için değişken

    while(!isValid1) // While false döndürdüğü sürece döngü çalışacak
    {
        Console.Write("Tatil için nereye gitmek istersiniz: (Bodrum - Marmaris - Çeşme): ");
        location = Console.ReadLine().ToLower();

        switch(location) // Geçerli girdi yapıldıysa döngü kırılcak
        {
            case "bodrum":
                locationPrice = 4000;
                isValid1 = true;
                break;

            case "marmaris":
                locationPrice = 3000;
                isValid1 = true;
                break;

            case "çeşme":
                locationPrice = 5000;
                isValid1 = true; 
                break;

            default:
                Console.WriteLine("Hatalı giriş yaptınız, tekrar deneyin.");
                break;
        }

    }

    #endregion

    #region HeadCount

    int headCount = 0; // Kişi sayısı
    bool isValid2 = false; // Döngü koşulu

    while (!isValid2)
    {
        Console.Write("Tatile kaç kişi çıkmayı planlıyorsunuz: ");
        bool isTrue1 = int.TryParse(Console.ReadLine(), out headCount);

        if (0 < headCount)
            isValid2 = true;  // Geçerli bir sayı girildiyse döngü koşulunu true atanır
        else
            Console.WriteLine("Yanlış işlem yaptınız, tekrar deneyin."); 
    }

    #endregion

    #region SummaryInfo

    string locationInfo = location;

    // Tatil beldesi hakkında bilgilendirme

    switch (locationInfo)
    { 
        case "bodrum":
            locationInfo = "Bodrum, güzel plajları, tarihi kalıntıları ve hareketli gece hayatıyla ünlüdür.";
            break;

        case "marmaris":
            locationInfo = "Marmaris, doğal güzellikleri ve yemyeşil ormanları ile tanınır.";
            break;

        default:
            locationInfo = "Çeşme, sıcak plajları ve şifalı kaplıcalarıyla ünlüdür.";
            break;
    }

            #endregion

    #region Transport

    int transportChoice = 0; // Tercih edilen ulaşım yolu
    bool isValid3 = false; // While döngüsünün koşulu

    while (!isValid3) // True olana kadar döngü çalışacak
    {
        Console.Write("Lütfen ulaşım aracı seçiniz: \r\n1 - Kara yolu (Kişi başı 1500 TL) \r\n2 - Hava yolu (Kişi başı 4000 TL): ");
        bool isTrue2 = int.TryParse(Console.ReadLine(),out transportChoice);

        // Eğer girdi koşulu sağlıyorsa while döngüsünü true döndür diyorum, döngü kırılacak

        if (isTrue2 == true && (transportChoice == 1 || transportChoice == 2))

        // Girdi istenilen aralıkta veya formatta değilse döngüyü tekrar döndürecek

            isValid3 = true;
        else
            Console.WriteLine("Hatalı giriş yaptınız, tekrar deneyin.");

    }

    #endregion

    #region TotalCost

    int transportCost = transportChoice == 1 ? 1500 : 4000; // Ulaşım maliyeti

    double totalCost = (locationPrice + transportCost) * headCount; // (Tatil beldesinin maliyeti + Ulaşım Yolu) * Kişi Sayısı

    Console.WriteLine($"Toplam tatil maliyeti: {totalCost} TL");

    #endregion

    #region ContinuePlanning

    Console.Write("Başka bir tatil planlamak ister misiniz? (Evet): ");
    string choose = Console.ReadLine().ToLower();

    // Kullanıcı yeni bir işlem yapmak isterse döngü baştan başlayacak

    if(choose == "evet")
        continuePlanning = true;
    else
        continuePlanning = false;

    #endregion

} while (continuePlanning) ;

Console.WriteLine("İyi günler dileriz :)");