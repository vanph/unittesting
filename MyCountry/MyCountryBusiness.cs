using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCountry.Models;
using MyCountry.Repository;

namespace MyCountry
{
    public class MyCountryBusiness
    {
        private readonly ICityRepository _cityRepository;
        private readonly IDistrictRepository _districtRepository;

        public MyCountryBusiness(ICityRepository cityRepository, IDistrictRepository districtRepository)
        {
            _cityRepository = cityRepository;
            _districtRepository = districtRepository;
        }

        public List<DistrictViewModel> GetDistrictInformations(string keyword, string cityCode)
        {
            var allDistricts = _districtRepository.GetAll();
            var allCities = _cityRepository.GetAll();

            var query = from d in allDistricts
                join c in allCities on d.CityCode equals c.Code
                select new DistrictViewModel { DistrictCode = d.Code, DistrictName = d.Name, CityCode = c.Code, CityName = c.Name };

            if (!string.IsNullOrEmpty(keyword))
            {
                keyword = keyword.ToLower();
                query = query.Where(a => a.DistrictCode.ToLower().Contains(keyword) || a.DistrictName.ToLower().Contains(keyword));
            }

            if (!string.IsNullOrEmpty(cityCode))
            {
                query = query.Where(a => a.CityCode.Contains(cityCode));
            }

            return query.ToList();
        }

        public List<District> GetDistricts(string keyword)
        {
            var allDistricts = _districtRepository.GetAll();

            var query = allDistricts;

            if (!string.IsNullOrEmpty(keyword))
            {
                keyword = keyword.ToLower();
                query = query.Where(a => a.Code.ToLower().Contains(keyword) || a.Name.ToLower().Contains(keyword)).ToList();
            }
           
            return query.ToList();
        }

    }
}
