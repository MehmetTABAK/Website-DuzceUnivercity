using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DüzceÜniversitesi.Models;

namespace DüzceÜniversitesi.ViewComponents
{
    public class Numbers : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var numberList = new List<AkademicNumbers>
            {
                new AkademicNumbers
                {
                    AkademicName="Rektörlük",
                    AcademicNumber="0 (850) 8008181",
                    AkademicFaks="0 (380) 5421103"
                },
                new AkademicNumbers
                {
                    AkademicName="Genel Sekreterlik",
                    AcademicNumber="0 (380) 5421110",
                    AkademicFaks="0 (380) 5421103"
                },
                new AkademicNumbers
                {
                    AkademicName="Eğitim Fakültesi",
                    AcademicNumber="0 (380) 5421355",
                    AkademicFaks="0 (380) 5421366"
                },
                new AkademicNumbers
                {
                    AkademicName="Fen Edebiyat Fakültesi",
                    AcademicNumber="0 (380) 5412404",
                    AkademicFaks="0 (380) 5412403"
                },
                new AkademicNumbers
                {
                    AkademicName="İlahiyat Fakültesi",
                    AcademicNumber="0 (380) 5421170",
                    AkademicFaks="0 (380) 5421180"
                },
                new AkademicNumbers
                {
                    AkademicName="İşletme Fakültesi",
                    AcademicNumber="0 (380) 5421370",
                    AkademicFaks="0 (380) 5421372"
                },
                new AkademicNumbers
                {
                    AkademicName="Mühendislik Fakültesi",
                    AcademicNumber="0 (380) 5421036",
                    AkademicFaks="0 (380) 5421037"
                },
                new AkademicNumbers
                {
                    AkademicName="Orman Fakültesi",
                    AcademicNumber="0 (380) 5421137",
                    AkademicFaks="0 (380) 5421136"
                },
                new AkademicNumbers
                {
                    AkademicName="Spor Bilimleri Fakültesi",
                    AcademicNumber="0 (380) 5421215",
                    AkademicFaks="0 (380) 5421365"
                },
                new AkademicNumbers
                {
                    AkademicName="Tıp Fakültesi",
                    AcademicNumber="0 (380) 5421416",
                    AkademicFaks="0 (380) 5421302"
                },
                new AkademicNumbers
                {
                    AkademicName="Ziraat Fakültesi",
                    AcademicNumber="0 (380) 5412294",
                    AkademicFaks="0 (380) 5412295"
                },
                new AkademicNumbers
                {
                    AkademicName="Sağlık Bilimleri Fakültesi",
                    AcademicNumber="0 (380) 5421141",
                    AkademicFaks="0 (380) 5421140"
                },
                new AkademicNumbers
                {
                    AkademicName="Akçakoca Meslek Yüksekokulu",
                    AcademicNumber="0 (380) 6118420",
                    AkademicFaks="0 (380) 6118798"
                },
                new AkademicNumbers
                {
                    AkademicName="Düzce Meslek Yüksekokulu",
                    AcademicNumber="0 (380) 5240099",
                    AkademicFaks="0 (380) 5240097"
                },
                new AkademicNumbers
                {
                    AkademicName="Kaynaşlı Meslek Yüksekokulu",
                    AcademicNumber="0 (380) 5442811",
                    AkademicFaks="0 (380) 5442812"
                },
                new AkademicNumbers
                {
                    AkademicName="Bilgi İşlem Daire Başkanlığı",
                    AcademicNumber="0 (380) 5421112",
                    AkademicFaks="0 (380) 5421113"
                },
                new AkademicNumbers
                {
                    AkademicName="İdari ve Mali İşler Daire Başkanlığı",
                    AcademicNumber="0 (380) 5421114",
                    AkademicFaks="0 (380) 5421115"
                },
                new AkademicNumbers
                {
                    AkademicName="Öğrenci İşleri Daire Başkanlığı",
                    AcademicNumber="0 (380) 5421118",
                    AkademicFaks="0 (380) 5421119"
                },
                new AkademicNumbers
                {
                    AkademicName="Personel Daire Başkanlığı",
                    AcademicNumber="0 (380) 5421120",
                    AkademicFaks="0 (380) 5421121"
                },
                new AkademicNumbers
                {
                    AkademicName="Havuz",
                    AcademicNumber="0 (380) 5421100-1370",
                    AkademicFaks="0 (380) 5421117"
                },
                new AkademicNumbers
                {
                    AkademicName="Düzce Teknopark",
                    AcademicNumber="0 (380) 5421500",
                    AkademicFaks="0 (380) 5421501"
                }
            };
            return View(numberList);
        }
    }
}
