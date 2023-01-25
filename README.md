# File Filter App (Window Form App) ![](https://img.shields.io/static/v1?label=Build&message=v1.0.0&color=green)
Là ứng dụng dùng để lọc file theo LOẠI của file. Các bạn có thể dùng để lọc theo tên chung, hoặc lọc theo nhiều tên. Ứng dụng này ban đầu được tạo ra dành cho các thợ chụp hình/người hay chụp ảnh/nhiếp ảnh gia dùng để lọc ra các file theo loại + theo tên người chụp. Ứng dụng sẽ được update trong tưuong lai.


Hướng dẫn: [READ ME]()

Download: [HERE]()

### Note

* Dùng khi muốn lọc nhiều ảnh sang một folder khác.
* Tên file có quy tắc, ở đây là list (Ví dụ như bạn có 1000 files ảnh là từ CANON000 - CANON999, cái này thì ai cũng hiểu rồi).
* Separator là phần ngăn cách giữa phần được lặp(Thường là phần chữ) và phần   
* Đặt tên file càng chính xác càng tốt (Ví dụ như bạn có 100 files DOCS_001 - DOCS_100 và 100 file là DOCS_A_ 001 - DOCS_A_100, thì tui khuyên là chia ra làm 2 lần - sau này sẽ update sau).
* Chi tiết còn lại các bạn xem docs ở trên

### Version

* ![](https://img.shields.io/static/v1?label=Build&message=v1.0.0&color=yellow): Hỗ trợ GUI, thêm đường dẫn bằng Folder Browse Dialog.
* ![](https://img.shields.io/static/v1?label=Build&message=v1.1.0&color=yellow): Thêm lựa chọn như là "File type", "Tên file".
* ![](https://img.shields.io/static/v1?label=Build&message=v1.2.0&color=yellow): "Responsive" cho GUI tốt hơn, thêm một số lựa chọn như là "Thêm folder con để lưu", "Tách các file theo loại".
* ![](https://img.shields.io/static/v1?label=Build&message=v1.3.0&color=yellow): Thêm tính năng hiện output về thông tin mà người dùng điền ở phần "Thông tin"; hiện output thông tin về ứng dụng.
* ![](https://img.shields.io/static/v1?label=Build&message=v1.3.1&color=yellow): Sửa lỗi các tính năng hiện output.
* ![](https://img.shields.io/static/v1?label=Build&message=v1.4.0&color=yellow) [Hiện tại]: Thêm dialog để nhập "Nhiều tên file", có hỗ trợ drag-drop để lấy tên các file cần lọc (với file txt, đọc trong file; với trực tiếp các file cần lọc, lấy tên).


### Ideas

Một thư mục nào đó của user chứa nhiều file cần phải phân loại, với thư mục này thì mình gọi nó là thư mục nguồn thư mục này sẽ chứa một đường dẫn tới nó (bắt đầu từ ổ đĩa C:\ hoặc D:\, ...).

Tiếp đó các bạn muốn các file này di chuyển tới một folder khác, thì folder này là folder đích. Tương tự với folder nguồn, thì folder đích cũng có một đường dẫn dẫn tới.

Như vậy thì đã có điểm đầu (điểm xuất phát để file di chuyển) và điểm đích (file di chuyển đến). Trong folder đích này, sẽ có thêm vài thư mục tuỳ theo loại file mà người dùng muốn chuyển. Ví dụ như bạn muốn chuyển một đống tài liệu bao gồm file .txt, .docx, .pdf, .xlsx, thì trong folder nguồn sẽ chứa bốn folder con là TXT, DOCX, PDF, XLSX, mở ra thì bạn sẽ thấy các file đã về với đúng từng loại.

Nhưng tuỳ theo bạn có muốn tạo folder mới để lưu các file không, thì cấu trúc sẽ khác. Giả sử:
* Nếu bạn muốn tạo folder mới để lưu: Folder đích > Folder mới > 4 folder (TXT, DOCX, PDF và XLSX).
* Nếu như bạn không tạo folder mới để lưu: Folder đích > 4 folder (TXT, DOCX, PDF và XLSX).

Ngoài ra thì bạn còn có thể gộp chung lại các file bên trong Folder đích nữa: Folder đích > Các files.