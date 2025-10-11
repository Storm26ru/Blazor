using Microsoft.AspNetCore.Components;

namespace BlazorStart.Components.Introduction
{
    public partial class Factorial
    {
        public long num { get; set; }
        void Input(ChangeEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Value.ToString())) num = Convert.ToInt64(e.Value);
            else num = 0;
        }
        long factorial(long num)
        {
            if (num > 1) num = num * factorial(num - 1);
            return num;
        }
    }
}
