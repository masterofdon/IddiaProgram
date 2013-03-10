using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IddiaProgram
{
    class Coupon
    {
        protected CouponProperties CouponProperties;
        protected List<BetMatch> Matches;
        public bool AddMatchToCoupon(BetMatch b)
            {
                return true;
            }
        private bool IsMatchAddable(BetMatch b)
            {
                return true;
            }
        public bool RemoveMatchFromCoupon(BetMatch b)
            {
                return false;
            }
        public bool CreateCoupon(BetMatch b)
            {
                return true;
            }
    }
}
