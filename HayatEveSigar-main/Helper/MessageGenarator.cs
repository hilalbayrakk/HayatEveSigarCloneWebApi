
namespace HayatEveSigar.Helper
{
    public static class MessageGenarator
    {
        public static readonly Dictionary<ResponseCodeEnum, string> ResponseMessages
            = new Dictionary<ResponseCodeEnum, string>
        {
        { ResponseCodeEnum.Success, "Ok" },


    { ResponseCodeEnum.GetAllDistrictsOperationFail, "İlçeler Listelenirken hata meydana geldi" },
    { ResponseCodeEnum.GetAllDistrictsOperationSuccess, "Tüm ilçeler Listelendi" },
    { ResponseCodeEnum.CreateDistrictOperationSuccess, "Yeni ilçe oluşturuldu" },
    { ResponseCodeEnum.CreateDistrictOperationFail, "Yeni ilçe oluşturulamadı" },
    { ResponseCodeEnum.DeleteDistrictOperationSuccess, "İlçe silindi" },
    { ResponseCodeEnum.DeleteDistrictOperationFail, "İlçe Silininirken hata meydana geldi" },


    { ResponseCodeEnum.CreateCityOperationSuccess, "Yeni il oluşturuldu" },
    { ResponseCodeEnum.CreateCityOperationFail, "Yeni il oluşturulamadı" },
    { ResponseCodeEnum.DeleteCityOperationFail, "İl Silininirken hata meydana geldi" },
    { ResponseCodeEnum.DeleteCityOperationSuccess, "İl Silindi" },
    { ResponseCodeEnum.GetAllCityOperationFail, "İl Listelenirken hata meydana geldi" },
    { ResponseCodeEnum.GetAllCityOperationSuccess, "Tüm iller Listelendi" },
    { ResponseCodeEnum.CityEditOperationFail, "İl Düzenlenirken Hata meydana geldi" },


    { ResponseCodeEnum.CreateNeigborhoodOperationSuccess, "Yeni Mahalle oluşturuldu" },
    { ResponseCodeEnum.CreateNeigborhoodOperationFail, "Yeni Mahalle oluşturulamadı" },
    { ResponseCodeEnum.DeleteNeigborhoodOperationFail, "Mahalle Silininirken hata meydana geldi" },
    { ResponseCodeEnum.DeleteNeigborhoodOperationSuccess, "Mahalle Silindi" },
    { ResponseCodeEnum.GetAllNeigborhoodOperationFail, "Mahalle Listelenirken hata meydana geldi" },
    { ResponseCodeEnum.GetAllNeigborhoodOperationSuccess, "Tüm Mahalleler Listelendi" },
    { ResponseCodeEnum.NeigborhoodEditOperationFail, "Mahalle Düzenlenirken Hata meydana geldi" },


    { ResponseCodeEnum.CreateAddressOperationSuccess, "Yeni Adres oluşturuldu" },
    { ResponseCodeEnum.CreateAddressOperationFail, "Yeni Adres oluşturulamadı" },
    { ResponseCodeEnum.DeleteAddressOperationFail, "Adres Silininirken hata meydana geldi" },
    { ResponseCodeEnum.DeleteAddressOperationSuccess, "Adres Silindi" },
    { ResponseCodeEnum.GetAllAddressOperationFail, "Adresler Listelenirken hata meydana geldi" },
    { ResponseCodeEnum.GetAllAddressOperationSuccess, "Tüm Adresler Listelendi" },
    { ResponseCodeEnum.AddressEditOperationFail, "Adres Düzenlenirken Hata meydana geldi" },
    { ResponseCodeEnum.GetAllDistrictByCityNameOperationFail, "Şehrin İlçeleri Listelenirken Hata meydana geldi" },
    { ResponseCodeEnum.GetAllDistrictByCityNameRequired, "Şehir Adını Kontrol Ediniz" },
    { ResponseCodeEnum.GetAdressByCityNameOperationFail, "Girilen İlde Kayıtlı Adres Bulunamadı" },
    { ResponseCodeEnum.GetAdressByCityNameRequired, "Şehir Adını Kontrol Ediniz" },
    { ResponseCodeEnum.GetAllAdressByDistrictOperationFail, "Girilen İlçede Kayıtlı Adres Bulunamadı" },
    { ResponseCodeEnum.GetAllAdressByDistrictRequired, "İlçe Adını Kontrol Ediniz" },

    };

        public static string ResponseMessageGenarator(ResponseCodeEnum ResponseCode)
        {
            return ResponseMessages[ResponseCode];
        }

    }
}