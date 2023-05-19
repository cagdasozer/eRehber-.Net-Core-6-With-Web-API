using eRehber.Entity.Dtos.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRehber.Business.Constants
{
	public class Messages
	{
		public static string PersonAdded = "KİŞİ EKLENDİ.";
		internal static string PersonDeleted = "KİŞİ SİLİNDİ.";
		internal static string PersonNotFound = "KİŞİ BULUNAMADI.";
		internal static string PersonListed = "KİŞİLER LİSTELENDİ.";
		internal static string PersonsNotFound = "KİŞİLER BULUNAMADI.";
		internal static string PersonUpdated = "KİŞİ GÜNCELLENDİ.";
		internal static string FirstNameNotEmpty = "İSİM BOŞ OLAMAZ.";
		internal static string FirstNameMaxLenght = "MAX UZUNLUK 30 KARAKTER. ";
		internal static string LastNameNotEmpty = "SOYİSİM BOŞ OLAMAZ.";
		internal static string LastNameMaxLenght = "MAX UZUNLUK 30 KARAKTER.";
		internal static string PhoneNumberNotEmpty = "TELEFON NUMARASI BOŞ OLAMAZ.";
		internal static string EMailNotEmpty = "E-MAİL BOŞ OLAMAZ.";
		internal static string CompanyNotEmpty = "ŞİRKET BİLGİSİ BOŞ OLAMAZ.";
		internal static string LocationNotEmpty = "KONUM BOŞ OLAMAZ.";
	}
}
