# Dai-ly

># I. Introduce:
Ứng dụng công nghệ thông tin cho mục đích sống của con người không còn xa lạ nữa.

Phần mềm quản lý đại lý của nhóm không chỉ giúp kiểm soát mà còn có thể quản lý mọi hoạt động của các đại lý một cách dễ dàng và hiệu quả nhất:

Bao gồm các công việc như:

Tiếp nhận đại lý mới

Kiểm soát các đại lý hiện có

Lập phiếu xuất hàng

Tra cứu đại lý hiện có

Lập phiếu thu tiền

Báo cáo doanh số và công nợ hàng tháng


># II. Build with: 
Những công cụ hỗ trợ trong việc xây dựng phần mềm:

Microsoft Visual Studio 2017- Xây dựng phần mềm

Download link: https://www.techspot.com/downloads/6278-visual-studio.html?fbclid=IwAR1VbAWsSon-JPiIRAtzDRhldrKAV4xdpv4vudhfhuE7GufAKdwQ1fJnecA

SQL Server Management Studio Express2012 - quản lý cơ sở dữ liệu

Download link: https://filehippo.com/download_sql_server_studio/?fbclid=IwAR1aJUIukjYQgXgU-J2p37JVS_dMMiMlSxhR_xjSIlzdyYnHufY9D5cc5i4

># IV. Functions:
  
  1. Tiếp nhận đại lý:
    ![quan_ly_dai_ly](https://user-images.githubusercontent.com/48848147/60589253-439c2180-9dc3-11e9-8f03-359a0f431bc1.JPG)
    
    Thuật toán:
    Bước 1: Nhập D1 từ người dung.
    Bước 2: Kết nối cơ sở dữ liệu.
    Bước 3: Đọc dữ liệu D3 từ bộ nhớ phụ.
    Bước 4: Kiểm tra thông tin loại đại lý có thuộc bộ nhớ phụ hay không, 
    và số lượng đại lý trong mỗi quận có vượt quá yêu cầu hay không.
    Bước 5: Nếu không thỏa ở bước 4 thì nhảy tới bước 8.
    Bước 6: Lưu D4 xuống bộ nhớ phụ.
    Bước 7: Xuất D5 ra máy in (nếu cần).
    Bước 8: Đóng kết nối cơ sở dữ liệu.
    Bước 9: Kết thúc

  2. Lập phiếu xuất hàng:
      
    TThuật toán:
    Bước 1: Nhập D1 từ người dung.
    Bước 2: Kết nối cơ sở dữ liệu.
    Bước 3: Đọc dữ liệu D3 từ bộ nhớ phụ.
    Bước 4: Kiểm tra mặt hàng và đơn vị tính được nhập vào có thuộc mặt hàng và 
    đơn vị tính từ bộ nhớ phụ hay không.
    Bước 5: Nếu không thỏa ở bước 4 thì nhảy tới bước 9.
    Bước 6: Lưu D4 xuống bộ nhớ phụ số tiền đại lý cần trả.
    Bước 7: Trả D6 cho người dùng.
    Bước 8: Xuất D5 ra máy in.
    Bước 9: Đóng kết nối cơ sở dữ liệu.
    Bước 10: Kết thúc.
                                

   3. Tra cứu đại lý:
    
    Thuật toán:
    Bước 1: Nhập D1 từ người dùng.
    Bước 2: Kết nối cơ sở dữ liệu.
    Bước 3: Đọc dữ liệu D3 từ bộ nhớ phụ.
    Bước 4: Kiểm tra tên quận hay tên đại lý được nhập vào có nằm trong bộ nhớ phụ hay không.
    Bước 5: Nếu không thỏa ở bước 4 thì nhảy tới bước 8.
    Bước 6: Trả D6 cho người dùng.
    Bước 7: Xuất D5 ra máy in (nếu cần).
    Bước 8: Đóng kết nối cơ sở dữ liệu.
    Bước 9: Kết thúc.


   4. Lập phiếu thu tiền
    
    Thuật toán:
    Bước 1: Nhập D1 từ người dùng.
    Bước 2: Kết nối cơ sở dữ liệu.
    Bước 3: Đọc dữ liệu D3 từ bộ nhớ phụ.
    Bước 4: Kiểm tra tên quận hay tên đại lý được nhập vào có nằm trong bộ nhớ phụ hay không,
    đồng thời kiểm tra quy định về số tiền thu có vượt quá hay nhỏ hơn số tiền đại lý đang nợ hay không 
    và số tiền nợ tối đa của các đại lý.
    Bước 5: Nếu không thỏa ở bước 4 thì nhảy tới bước 9.
    Bước 6: Lưu xuống bộ nhớ phụ số tiền đại lý đã trả.
    Bước 7: Trả D6 cho người dùng.
    Bước 8: Xuất D5 ra máy in (nếu cần).
    Bước 9: Đóng kết nối cơ sở dữ liệu.
    Bước 10: Kết thúc.


   5. Báo cáo doanh số
   
    Thuật toán:
    Bước 1: Nhập D1 từ người dùng.
    Bước 2: Kết nối cơ sở dữ liệu.
    Bước 3: Đọc dữ liệu D3 từ bộ nhớ phụ.
    Bước 4: Kiểm tra tháng cần báo cáo được nhập vào có đúng hay không.
    Bước 5: Nếu không thỏa ở bước 4 thì nhảy tới bước 8.
    Bước 6: Trả D6 cho người dùng.
    Bước 7: Xuất D5 ra máy in (nếu cần).
    Bước 8: Đóng kết nối cơ sở dữ liệu.
    Bước 9: Kết thúc.


   6. Báo cáo công nợ
   
    Thuật toán:
    Bước 1: Nhập D1 từ người dùng.
    Bước 2: Kết nối cơ sở dữ liệu.
    Bước 3: Đọc dữ liệu D3 từ bộ nhớ phụ.
    Bước 4: Kiểm tra tháng cần báo cáo được nhập vào có đúng hay không.
    Bước 5: Nếu không thỏa ở bước 4 thì nhảy tới bước 8.
    Bước 6: Trả D6 cho người dùng.
    Bước 7: Xuất D5 ra máy in (nếu cần).
    Bước 8: Đóng kết nối cơ sở dữ liệu.
    Bước 9: Kết thúc.


# V. Example:   
# VI. FAQ & Usage:
# VII. Contributing:
# IV. Authors:
An Xuân Tuấn - 16521355

Nguyễn Tấn Phát - 16521619

Lã Tuấn Vinh - 16521439

Phạm Xuân Linh - 16521717
