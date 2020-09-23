using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvc.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>() 
            {
                new Category() { KategoriAdi="Adalet ve Güvenlik"},
                new Category() { KategoriAdi="Ağaç İşleri, Kağıt ve Kağıt Ürünleri"},
                new Category() { KategoriAdi="Bilişim Teknolojileri"},
                new Category() { KategoriAdi="Cam, Çimento ve Toprak"},
                new Category() { KategoriAdi="Çevre"},
                new Category() { KategoriAdi="Eğitim"},
                new Category() { KategoriAdi="Elektrik ve Elektronik"},
                new Category() { KategoriAdi="Enerji"},
                new Category() { KategoriAdi="Finans"},
                new Category() { KategoriAdi="Gıda"},
                new Category() { KategoriAdi="İnşaat"},
                new Category() { KategoriAdi="İş ve Yönetim"},
                new Category() { KategoriAdi="Kimya, Petrol, Lastik ve Plastik"},
                new Category() { KategoriAdi="Kültür, Sanat ve Tasarım"},
                new Category() { KategoriAdi="Maden"},
                new Category() { KategoriAdi="Medya, İletişim ve Yayıncılık"},
                new Category() { KategoriAdi="Metal"},
                new Category() { KategoriAdi="Otomotiv"},
                new Category() { KategoriAdi="Sağlık ve Sosyal Hizmetler"},
                new Category() { KategoriAdi="Spor ve Rekreasyon"},
                new Category() { KategoriAdi="Tarım, Avcılık ve Balıkçılık"},
                new Category() { KategoriAdi="Tekstil, Hazır Giyim, Deri"},
                new Category() { KategoriAdi="Ticaret (Satış ve Pazarlama)"},
                new Category() { KategoriAdi="Toplumsal ve Kişisel Hizmetler"},
                new Category() { KategoriAdi="Turizm, Konaklama, Yiyecek-İçecek Hizmetleri"},
                new Category() { KategoriAdi="Ulaştırma, Lojistik ve Haberleşme"},
            };

            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();

            List<Blog> bloglar = new List<Blog>() 
            {
                new Blog() { Baslik="Adalet ve Güvenlik", Aciklama="Adalet ve Güvenlik alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik="Adalet ve Güvenlik alanındaki meslek incelemeleri ve detayları", Resim="", CategoryId=1},
                new Blog() { Baslik="Ağaç İşleri, Kağıt ve Kağıt Ürünleri", Aciklama="Ağaç İşleri, Kağıt ve Kağıt Ürünleri alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-15), Anasayfa=true, Onay=true, Icerik="Ağaç İşleri, Kağıt ve Kağıt Ürünleri alanındaki meslek incelemeleri ve detayları", Resim="", CategoryId=2},
                new Blog() { Baslik="Bilişim Teknolojileri", Aciklama="Bilişim Teknolojileri alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-12), Anasayfa=true, Onay=true, Icerik="Bilişim Teknolojileri alanındaki meslek incelemeleri ve detayları", Resim="", CategoryId=3},
                new Blog() { Baslik="Cam, Çimento ve Toprak", Aciklama="Cam, Çimento ve Toprak alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-20), Anasayfa=true, Onay=true, Icerik="Cam, Çimento ve Toprak alanındaki meslek incelemeleri ve detayları", Resim="", CategoryId=4},
                new Blog() { Baslik="Çevre", Aciklama="Çevre alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-45), Anasayfa=false, Onay=true, Icerik="Çevre alanındaki meslek incelemeleri ve detayları", Resim="", CategoryId=5},
                new Blog() { Baslik="Eğitim", Aciklama="Eğitim alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-28), Anasayfa=true, Onay=true, Icerik="Eğitim alanındaki meslek incelemeleri ve detayları", Resim="", CategoryId=6},
                new Blog() { Baslik="Elektrik ve Elektronik", Aciklama="Elektrik ve Elektronik alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-5), Anasayfa=true,Onay=true, Icerik="Elektrik ve Elektronik alanındaki meslek incelemeleri ve detayları", Resim="", CategoryId=7},
                new Blog() { Baslik="Enerji", Aciklama="Enerji alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-33), Anasayfa=true, Onay=true, Icerik="Enerji alanındaki meslek incelemeleri ve detayları", Resim="", CategoryId=8},
                new Blog() { Baslik="Finans", Aciklama="Finans alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-94), Anasayfa=false, Onay=true, Icerik="Finans alanındaki meslek incelemeleri ve detayları", Resim="", CategoryId=9},
                new Blog() { Baslik="Gıda", Aciklama="Gıda alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-50), Anasayfa=false, Onay=true, Icerik="Gıda alanındaki meslek incelemeleri ve detayları", Resim="", CategoryId=10},
                new Blog() { Baslik="İnşaat", Aciklama="İnşaat alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik="İnşaat alanındaki meslek incelemeleri ve detayları", Resim="", CategoryId=11},
                new Blog() { Baslik="İş ve Yönetim", Aciklama="İş ve Yönetim alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-26), Anasayfa=true, Onay=true, Icerik="İş ve Yönetim alanındaki meslek incelemeleri ve detayları", Resim="", CategoryId=12},
                new Blog() { Baslik="Kimya, Petrol, Lastik ve Plastik", Aciklama="Kimya, Petrol, Lastik ve Plastik alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-35), Anasayfa=true, Onay=true, Icerik="Kimya, Petrol, Lastik ve Plastik alanındaki meslek incelemeleri ve detayları", Resim="", CategoryId=13},
                new Blog() { Baslik="Kültür, Sanat ve Tasarım", Aciklama="Kültür, Sanat ve Tasarım alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-16), Anasayfa=true, Onay=true, Icerik="Kültür, Sanat ve Tasarım alanındaki meslek incelemeleri ve detayları", Resim="", CategoryId=14},
                new Blog() { Baslik="Maden", Aciklama="Maden alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=false, Onay=true, Icerik="Maden alanındaki meslek incelemeleri ve detayları", Resim="", CategoryId=15},
                new Blog() { Baslik="Medya, İletişim ve Yayıncılık", Aciklama="Medya, İletişim ve Yayıncılık alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-78), Anasayfa=true, Onay=true, Icerik="Medya, İletişim ve Yayıncılık alanındaki meslek incelemeleri ve detayları",Resim="", CategoryId=16},
                new Blog() { Baslik="Metal", Aciklama="Metal alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik="Metal alanındaki meslek incelemeleri ve detayları", Resim="", CategoryId=17},
                new Blog() { Baslik="Otomotiv", Aciklama="Otomotiv alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik="Otomotiv alanındaki meslek incelemeleri ve detayları", Resim="", CategoryId=18},
                new Blog() { Baslik="Sağlık ve Sosyal Hizmetler", Aciklama="Sağlık ve Sosyal Hizmetler alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-56), Anasayfa=true, Onay=true, Icerik="Sağlık ve Sosyal Hizmetler alanındaki meslek incelemeleri ve detayları", Resim="", CategoryId=19},
                new Blog() { Baslik="Spor ve Rekreasyon", Aciklama="Spor ve Rekreasyon alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-62), Anasayfa=false, Onay=true,Icerik="Spor ve Rekreasyon alanındaki meslek incelemeleri ve detayları", Resim="", CategoryId=20},
                new Blog() { Baslik="Tarım, Avcılık ve Balıkçılık", Aciklama="Tarım, Avcılık ve Balıkçılık alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-77), Anasayfa=true, Onay=true, Icerik="Tarım, Avcılık ve Balıkçılık alanındaki meslek incelemeleri ve detayları", Resim="", CategoryId=21},
                new Blog() { Baslik="Tekstil, Hazır Giyim, Deri", Aciklama="Tekstil, Hazır Giyim, Deri alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-40), Anasayfa=true, Onay=true, Icerik="Tekstil, Hazır Giyim, Deri alanındaki meslek incelemeleri ve detayları", Resim="", CategoryId=22},
                new Blog() { Baslik="Ticaret (Satış ve Pazarlama)", Aciklama="Ticaret (Satış ve Pazarlama) alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-20), Anasayfa=false, Onay=true, Icerik="Ticaret (Satış ve Pazarlama) alanındaki meslek incelemeleri ve detayları", Resim="", CategoryId=23},
                new Blog() { Baslik="Toplumsal ve Kişisel Hizmetler", Aciklama="Toplumsal ve Kişisel Hizmetler alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-1), Anasayfa=true, Onay=true, Icerik="Toplumsal ve Kişisel Hizmetler alanındaki meslek incelemeleri ve detayları", Resim="", CategoryId=24},
                new Blog() { Baslik="Turizm, Konaklama, Yiyecek-İçecek Hizmetleri", Aciklama="Turizm, Konaklama, Yiyecek-İçecek Hizmetleri alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik="Turizm, Konaklama, Yiyecek-İçecek Hizmetleri alanındaki meslek incelemeleri ve detayları", Resim="", CategoryId=25},
                new Blog() { Baslik="Ulaştırma, Lojistik ve Haberleşme", Aciklama="Ulaştırma, Lojistik ve Haberleşme alanındaki meslek incelemeleri", EklenmeTarihi=DateTime.Now.AddDays(-65), Anasayfa=false, Onay=true, Icerik="AUlaştırma, Lojistik ve Haberleşme4 alanındaki meslek incelemeleri ve detayları", Resim="", CategoryId=26},
            };
            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}