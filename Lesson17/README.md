Bài 1: thực hành kế thừa
https://media.cheggcdn.com/study/b73/b732ef45-3de6-496f-9ab9-7d3c0844a251/objectassignment4.png

Bài 2:
Thiết kế và triển khai lớp Circle (hình tròn) và lớp con của nó Cylinder (hình trụ). Lớp Circle có những thuộc tính mô tả bán kính, màu sắc, các getter/setter cho các thuộc tính đó, và những thuộc tính liên đới như diện tích. Lớp Cylinder mở rộng lớp Circle bằng cách bổ sung thuộc tính chiều cao cũng như có thể có thêm phương thức lấy thể tích.
Cả hai lớp đều phải cài đè phương thức ToString để in ra thông tin chi tiết các thuộc tính của đổi tượng.
1. Hãy vẽ giản đồ UML cho hai lớp trên, với mô tả về các thuộc tính, các phương thức khởi tạo cần thiết, cũng như các phương thức tính ra các thuộc tính đặc trưng của mỗi lớp.
2. Viết chương trình sử dụng tới hai lớp đối tượng kia với mục đích kiểm thử.

======================

- Override(ghi đè): được sử dụng khi muốn thay đổi hành vi của một phương thức ở lớp cha trong lớp con.
<access_modifier> override <data_type> <proterty_name>;
Khi đấy phương thức ở lớp cha sẽ cần thêm virtual vào trước kiểu dữ liệu phương thức
<access_modifier> virtual <data_type> <proterty_name>;