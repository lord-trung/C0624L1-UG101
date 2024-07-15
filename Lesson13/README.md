Câu 1: Viết hàm đặt tên là InitCaroTable để tạo 1 mảng 2 chiều đặt tên là caro-table có kích cỡ là n x n (với n = 15)

Câu 2: Tiếp tục triển khai mã nguồn cho hàn InitCaroTable ở Bai01 để hiển thị ra màn hình với yêu cầu sau
    Các giá có row = 0 thì sẽ hiển thị từ 1 đến n-1
    Các giá trị có col = 0 thì sẽ hiển thị từ 1 đến n-1
    các giá trị còn lại thì hiển thị dấu "-"

Câu 3: Viết Phương thức DrawCaroTable dựa vào dữ liệu trong mảng caro-table để hiển thị ra màn hình

Câu 4: Hãy gán giá trị caro_table[5,5] = "X" sau đó gọi lại hàm DrawTable và quan sát kết quả

câu 5: trong phương thức Main, hãy gán giá trị caro_table[5,6] = "O" sau đó gọi hàm DrawTable và quan sát kết quả

Câu 6: yêu cầu người dùng nhập vào 2 giá trị x và y sau đó gán caro_table[x, y] = "X" và gọi hàm DrawTable, việc này sẽ được lặp mãi mãi.

Câu 7: xử lý để cho 2 người chơi xen kẻ theo nguyên tắc người chơi 1 là X, người chơi 2 thì O, và sau khi lượt của người thì đến lượt chơi của
người kia

Câu 8: hiển thị 1 dòng chữ lượt chơi của người "Player 1" hoặc "Player 2" trước khi người chơi nhập x và y

Câu 9: hãy tách đoạn chơi XO ra thành 1 hàm và đặt tên là PlayGame

Câu 10: khi hiển thị bàn caro thì:
    số sẽ hiển thị màu Yellow
    X sẽ hiển thị màu Red
    O sẽ hiển thị màu Green
    - sẽ hiển thị màu mặc định

Câu số 11: kiểm tra tính hợp của người chơi khi người chơi nhập x và y. x và y chỉ hợp lệ khi:
    x và y > 0
    x và y < 15
    caro_table[x, y] phải đang là dấu "-"
    nếu người dùng nhập vào x và y không hợp lệ thì hiển thị thông báo "Invalid Position" và yêu cầu người chơi đó nhập lại, cho đến khi x và hợp thì mới được chuyển sang người khác.

GameCaro: Tạo hàm xét điều kiện chiến thắng của game và hoàn thiện game.