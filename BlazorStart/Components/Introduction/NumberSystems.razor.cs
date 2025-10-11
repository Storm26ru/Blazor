using Microsoft.JSInterop;

namespace BlazorStart.Components.Introduction
{
    public partial class NumberSystems
    {
        public int SystemIn { get; set; } = 10;
        public int SystemOut { get; set; } = 2;
        public long Number { get; set; }

        void convert_to_Number(string num)
        {
            try
            {
                if (!string.IsNullOrEmpty(num)) Number = Convert.ToInt64(num, SystemIn);
            }
            catch (FormatException)
            {
                JSRuntime.InvokeVoidAsync("console.log", "Не верно введенное число для данной системы исчисления");

            }
        }
    }
}
