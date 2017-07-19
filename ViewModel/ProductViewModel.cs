using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ExpandableView.Model;

namespace ExpandableView.ViewModel
{
    public class ProductViewModel
    {
        public ObservableCollection<Product> Products{get;set;}

        public ProductViewModel()
        {
            Products = new ObservableCollection<Product>
            {
                new Product()
                {
                    Name = "Vaseline",
                    Description = "body lotion"
                },
                new Product()
                {
                    Name = "Glycerine",
                    Description = "Face pemper"
                },
                new Product()
                {
                    Name = "Huawei",
                    Description = "Smartphone"
                }
            };
        }
    }
}
