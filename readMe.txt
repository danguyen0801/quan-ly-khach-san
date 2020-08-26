Để cài đặt source code UngDungQuanLyKhachSan cần phải:

- Thực thi 2 file .sql trong SSMS để tạo cơ sở dữ liệu:
	+ Chạy SQL_TaoCSDL.sql	trong folder readme
	+ Chạy file SQL_function_proc.sql chứa trong folder readme
- Kiểm tra thư mục debug của Source code có chứa file "Bunifu_UI_v1.52.dll" hay không
	+ Nếu không có, copy file "Bunifu_UI_v1.52.dll" vào thư mục debug của source code
	+ Mở ứng dụng bằng Visual Studio, chọn " Tools --> Choose ToolBox Items... --> Browse.. 
		--> chọn đường dẫn tới file "Bunifu_UI_v1.52.dll" trong folder debug vừa copy --> OK
- Mở ứng dụng bằng Visual Studio, tại file "ConnectionString.cs", thực hiện sửa đường liên kết của biến "connectingString"
	+ Lấy liên kết từ Data Source liên kết đến Database của SQL Server: trong giao diện Visual Studio, chọn Tools -->Connect to Database 
		-->nhập tên Database Server chứa cơ sở dữ liệu tạo bởi 2 file sql lúc nãy vào "Server name" 
		--> tại ô "Select or enter a database name" , lựa chọn tên database QUANLYKHACHSAN đã tạo
		--> Nhấp chọn vào "Advaned..." --> copy Data Source liên kết đến cơ sở dữ liệu.	
	+ Sau khi lấy được Data Source, mở class ConnectionString và thay đổi giá trị của "connectingString" thành Data Source vừa lấy được.
		