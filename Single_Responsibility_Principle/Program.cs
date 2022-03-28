using Single_Responsibility_Principle;

double toplamCevre = 0;
List<Kare> kareList = new List<Kare>()
      {
          new Kare(2),
          new Kare(3)
      };

CevreHesapla cevreHesapla = new CevreHesapla(kareList);
toplamCevre = cevreHesapla.ToplamCevreUzunlugunuHesapla();

CevreyiEkranaYazdir cevreYazdir = new CevreyiEkranaYazdir(toplamCevre, "Kare");
cevreYazdir.EkranaYaz();