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
  
   Tiếp nhận đại lý:
    ![tiep_nhan_dai_ly](https://user-images.githubusercontent.com/48848147/60590935-734d2880-9dc7-11e9-9444-7625b4251da4.JPG)
    
    Các ký hiệu:
    D1: Tên đại lý, loại đại lý, địa chỉ, điện thoại, ngày tiếp nhận, email.
    D2: Không có.
    D3: Danh sách các loại đại lý.
    D4: D1.
    D5: D4.
    D6: Không có.

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

   Lập phiếu xuất hàng:
    ![phieu_xuat_hang](https://user-images.githubusercontent.com/48848147/60590821-32edaa80-9dc7-11e9-92a5-73a6f3501a9e.JPG)
    
    Các ký hiệu:
    D1: Tên đại lý, các mặt hàng và đơn vị tính, số lượng, đơn giá tương ứng cho loại mặt hàng đó.
    D2: Không có.
    D3: Danh sách các loại mặt hàng, loại đơn vị tính.
    D4: Tổng số tiền đại lý cần trả.
    D5: D1 và ngày lập phiếu.
    D6: D5.

    Thuật toán:
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
                                

    Tra cứu đại lý:
    ![tra_cuu](https://user-images.githubusercontent.com/48848147/60591089-d50d9280-9dc7-11e9-878d-227fc61aa71d.JPG)
    
    Các ký hiệu:
    D1: Tên đại lý hoặc tên quận cần tìm.
    D2: Không có.
    D3: Danh sách các loại đại lý cần tìm, loại, quận và tiền nợ của đại lý đó.
    D4: Không có.
    D5: D3.
    D6: D5.

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
    
    Các ký hiệu:
    D1: Tên đại lý, địa chỉ, điện thoại, email, số tiền thu.
    D2: Không có.
    D3: Danh sách các đại lý đang thu tiền.
    D4: Số tiền đã thu được.
    D5: D1 và ngày thu tiền.
    D6: D5.
 
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
   
    Các ký hiệu:
    D1: Tháng cần báo cáo.
    D2: Không có.
    D3: Danh sách các đại lý, số phiếu xuất, tổng giá trị và tỷ lệ.
    D4: Không có.
    D5: D3 và tháng cần báo cáo.
    D6: D5.

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
   
    Các ký hiệu:
    D1: Tháng cần báo cáo.
    D2: Không có.
    D3: Danh sách các đại lý, nợ đầu, phát sinh và nợ cuối.
    D4: Không có.
    D5: D3 và tháng cần báo cáo.
    D6: D5.

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
