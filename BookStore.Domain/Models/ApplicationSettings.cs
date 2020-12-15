using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Domain.Models
{
    public class ApplicationSettings
    {
        public string JWT_Secret { get; set; }
        public string Client_URL { get; set; }
    }
}
