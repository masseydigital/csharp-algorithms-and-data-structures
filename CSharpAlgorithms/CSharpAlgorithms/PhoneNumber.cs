using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    public class PhoneNumber
    {
        public string AreaCode { get; }
        public string Exchange { get; }
        public string Number { get; }

        public PhoneNumber(string areaCode, string exchange, string number)
        {
            AreaCode = areaCode;
            Exchange = exchange;
            Number = number;
        }

        public override bool Equals(object obj)
        {
            var number = obj as PhoneNumber;
            if (number == null)
                return false;

            return string.Equals(a: AreaCode, b: number.AreaCode) &&
                string.Equals(a: Exchange, b: number.Exchange) &&
                string.Equals(a: Number, b: number.Number);
        }

        public static bool operator == (PhoneNumber left, PhoneNumber right)
        {
            if (object.ReferenceEquals(left, right))
                return true;

            if (object.ReferenceEquals(null, left))
                return false;

            return left.Equals(right);
        }

        public static bool operator != (PhoneNumber left, PhoneNumber right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                const int HashingBase = (int)2166136261;
                const int HashingMultiplier = 16777619;

                int hash = HashingBase;
                hash = (hash * HashingMultiplier) ^ (!object.ReferenceEquals(null, AreaCode) ? AreaCode.GetHashCode() : 0);
                hash = (hash * HashingMultiplier) ^ (!object.ReferenceEquals(null, Exchange) ? Exchange.GetHashCode() : 0);
                hash = (hash * HashingMultiplier) ^ (!object.ReferenceEquals(null, Number) ? Number.GetHashCode() : 0);

                return hash;
            }
    
        }        
    }
}
