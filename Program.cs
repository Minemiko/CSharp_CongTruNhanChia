internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Địt vô mặt cuộc đời");
        int so1, so2;
        Console.Write("Nhập số 1: ");
        so1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập số 2: ");
        so2 = Convert.ToInt32(Console.ReadLine());
        /*tong = so1 + so2;
        hieu = so1 - so2;
        tich = so1 * so2;*/
        Console.WriteLine("Tổng của hai số " + so1 + " và " + so2 + " là: " + TinhTong(so1, so2));
        // Console.WriteLine("Tổng của hai số {0} và {1} là: {2}", so1, so2, tong);
        // Console.WriteLine($"Tổng của hai số {so1} và {so2} là: {tong}");
        Console.WriteLine("Hiệu của hai số " + so1 + " và " + so2 + " là: " + TinhHieu(so1, so2));
        Console.WriteLine("Tích của hai số " + so1 + " và " + so2 + " là: " + TinhTich(so1, so2));
        try
        {
            //thuong = so1 / so2;
            Console.WriteLine("Thương của hai số " + so1 + " và " + so2 + " là: " + TinhThuong(so1, so2));
        } catch (Exception e){
            Console.WriteLine("Đồ ngu, đồ ăn hại, CÚT. " + e.Message);
        }
    }

    private static int TinhTong(int a, int b)
    {
        return a + b;
    }
    private static int TinhHieu(int a, int b)
    {
        return a - b;
    }
    private static int TinhTich(int a, int b)
    {
        return a * b;
    }
    private static double TinhThuong(double a, double b)
    {
            return a / b;
    }
}