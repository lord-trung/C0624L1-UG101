Bai01: Sử dụng kiến thức OOP tạo lớp Shoe gồm 3 thuộc tính: Size, Price, Brand
    Sau đó tạo 2 đối tượng lần lượt là adidas và nike và gán các giá trị cho thuộc tính tương ứng

Bai02: tạo một lớp đặt là Staff, có 3 thuộc tính Fullname, Age, Gender
    tạo 2 constructor, 1 constructor gán giá trị ban đầu cho Fullname và 1 Constructor gán giá trị ban đầu cho Fullname và Age
    tạo 2 đối tượng lần lượt sử dụng 2 constructor

Bai03: thiết kế lớp Student => tự suy nghĩ để liệt kê các properties
    và tạo 2 đến 3 constructor
    tạo method GetInfo để  hiển thị thông tin của mỗi Student
    tạo 2 đối tượng sử dụng 2 constructor

======================

** Khai báo class. Thuộc tính khai báo có quyền truy cập mặc đinh là Internal
    <access_modifier> class <class_name> {}

** khai báo thuộc tính. Thuộc tính khai báo có quyền truy cập mặc định là Private.
    <access_modifier> <data_type> <proterty_name> { set; get; }

** access modifier: Quyền truy cập.
    internal - Truy cập bị giới hạn trong phạm vi Assembly của dự án hiện tại.
    public - Không có bất kỳ giới hạn nào khi truy cập vào các thành viên công khai.
    private - Truy cập bị hạn chế trong phạm vi của định nghĩa Class.
    protected - Truy cập bị giới hạn trong phạm vi định nghĩa của Class và bất kỳ các class con thừa kế từ class này.

** property: Thuộc tính có trong class. Thuộc tính có thể là một kiểu giá trị hoặc là một hàm.

** { set; get } cho phép gán (set) và lấy giá trị (get) property, nếu không cho thì thêm private vào trước set hoặc get
property khi khai báo mặc định là { set; get; }