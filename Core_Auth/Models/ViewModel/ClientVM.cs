using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Core_Auth.Models.ViewModel
{
    public class ClientVM
    {
        public ClientVM()
        {
            this.SpotList = new List<int>();
        }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        [Required, DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
        public int Phone { get; set; }
        public string Picture { get; set; }
        public IFormFile PictureFile { get; set; }
        public bool MaritialStatus { get; set; }
        public List<int> SpotList { get; set; }
    }
}
