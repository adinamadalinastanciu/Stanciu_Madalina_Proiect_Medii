﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stanciu_Madalina_Proiect_Medii.Models
{
    public class Producer
    {
        public int ID { get; set; }
        public string ProducerName { get; set; }
        public Product Product { get; set; }
    }
}
