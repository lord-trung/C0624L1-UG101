namespace Lesson12;
using System.Text;

class Bai01
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        // Thiết kế chương trình thực hiện các phép tính cộng, trừ, nhân và chia
        // yêu cầu:
        // hiển thị lên màn hình menu gồm có các chức năng sau:
        // Menu
        // Nhấn phím 1 để thực hiện phép cộng
        // Nhấn phím 2 để thực hiện phép trừ
        // Nhấn phím 3 để thực hiện phép nhân
        // Nhấn phím 4 để thực hiện phép chia
        // Nhân phím 0 để thoát khỏi chương trình
        // Chọn phím: ____
        // Nếu người dùng không nhập các số từ 1-4 hoặc 0 thì yêu cầu người dùng nhập lại
        // Nếu người dùng nhập số 1 thì hiển thị: BẠN CHỌN PHÉP CỘNG
        // Nếu người dùng nhập số 2 thì hiển thị: BẠN CHỌN PHÉP TRỪ
        // Nếu người dùng nhập số 3 thì hiển thị: BẠN CHỌN PHÉP NHÂN
        // Nếu người dùng nhập số 4 thì hiển thị: BẠN CHỌN PHÉP CHIA
        // ----------
        // Gợi ý để thoát khỏi chương trình thì dùng Environment.Exit(0)

        Menu();
    }

    static void Menu()
    {
        Console.WriteLine("---------------MENU---------------");
        Console.Write($" 1: Thực hiện phép cộng.\n 2: Thực hiện phép trừ.\n 3: Thực hiện phép nhân.\n 4: Thực hiện phép chia.");
        Console.WriteLine();
        Console.Write("Chọn phép tính: ");
        string input = Console.ReadLine();
      
        SelectMenu(input);
    }

    static void SelectMenu(string choice)
    {
        bool check;
        if (choice == "0" || choice == "1" || choice == "2" || choice == "3" || choice == "4")
        {
            check = true;
        }
        else check = false;

        while (!check)
        {
            Menu();           
        }

        int selectedMenu;
        int.TryParse(choice, out selectedMenu);

        switch (selectedMenu)
        {
            case 0:
                Environment.Exit(0);
                break;
            case 1:
                Console.WriteLine("BẠN CHỌN PHÉP CỘNG");
                break;
            case 2:
                Console.WriteLine("BẠN CHỌN PHÉP TRỪ");
                break;
            case 3:
                Console.WriteLine("BẠN CHỌN PHÉP NHÂN");
                break;
            case 4:
                Console.WriteLine("BẠN CHỌN PHÉP CHIA");
                break;
        }
    }
}