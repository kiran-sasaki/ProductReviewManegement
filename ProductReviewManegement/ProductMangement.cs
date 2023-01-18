using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManegement
{
    public class ProductMangement
    {
        List<ProductReview> productReviewList = new List<ProductReview>();

        public void AddProductList(List<ProductReview> list)
        {
            this.productReviewList = list;
        }
    }
}
