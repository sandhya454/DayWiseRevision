using System;

namespace Day29Concepts
{
    public class NullableTypes
    {
        /// <summary>
        /// the default values of value type is 0 and reference type 
        /// is null inorder to store the null values in value types
        /// we have 2 ways by using Nullable and by using nullcoalesing (?) operator
        /// </summary>
        public void NullabaleExample()
        {
            Nullable<int> number = null;
            Nullable<long> number2 = null;
            Nullable<decimal> number3 = null;
            Nullable<float> number4 = null;
            Nullable<double> number5 = null;
            Nullable<bool> isValid= null;

            int? number6= null;
            long? number7= null;
            double? number8= null;
            float? number9 = null;
            bool? isConfirm= null;
            decimal? number10 = null;
        }
    }
}
