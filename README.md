# Đai-lý

># I. Introduce:
 Ứng dụng công nghệ thông tin cho mục đích sống của con người không còn xa lạ nữa.

 Phần mềm quản lý đại lý của nhóm không chỉ giúp kiểm soát mà còn có thể quản lý mọi hoạt động của các đại lý một cách dễ dàng và hiệu quả nhất:

+ Bao gồm các công việc như:

     • Tiếp nhận đại lý mới

     • Kiểm soát các đại lý hiện có

     • Lập phiếu xuất hàng

     • Tra cứu đại lý hiện có

     • Lập phiếu thu tiền

     • Báo cáo doanh số và công nợ hàng tháng


># II. Build with: 
 Những công cụ hỗ trợ trong việc xây dựng phần mềm:

+ Microsoft Visual Studio 2017- Xây dựng phần mềm

+ Download link: https://www.techspot.com/downloads/6278-visual-studio.html?fbclid=IwAR1VbAWsSon-JPiIRAtzDRhldrKAV4xdpv4vudhfhuE7GufAKdwQ1fJnecA

+ SQL Server Management Studio Express2012 - quản lý cơ sở dữ liệu

+ Download link: https://filehippo.com/download_sql_server_studio/?fbclid=IwAR1aJUIukjYQgXgU-J2p37JVS_dMMiMlSxhR_xjSIlzdyYnHufY9D5cc5i4

># III. REPORT:

 ## CHƯƠNG 1: HIỆN TRẠNG: 
  
   **1.	Khảo sát hiện trạng:**
        _ Khảo sát hiện trạng về việc giám sát các hoạt động của các đại lý tạp hóa.
        
   **1.1 Hiện trạng tổ chức**
       
   + Tổ chức bao gồm Giám đốc, Phó Giám Đốc, Phòng kế toán, Phòng tiếp nhận hồ sơ, Quản lý kho, Kinh tế & đối ngoại và Phòng tài chính Marketing.

   + Sơ đồ cơ cấu tổ chức :
![sơ đồ](https://user-images.githubusercontent.com/48848147/60735563-22336500-9f7e-11e9-9b72-cf6808fe47fe.JPG)

	Đối nội:
+	Phòng kế toán: chủ yếu lập phiếu thu tiền và thu tiền từ các đại lý.
+	Phòng tiếp nhận hồ sơ: khi có một hồ sơ được gửi tới để đăng ký trở thành đại lý tạp hóa.
+	Khu quản lý kho: trực tiếp việc kiểm tra hàng hóa, nhập hàng và phần phối xuất hàng và sản phẩm đến các đại lý.
+	Phòng tài chính - Marketing: sẽ chịu trách nhiệm trong việc lập báo các doanh số của các đại lý, sản phẩm nào bán được và bán không được và công nợ của các đại lý và đồng thời quảng cáo các sản phẩm mới tới các đại lý.


	Đối ngoại:

+	Phòng kinh tế-đối ngoại có chức năng trong việc:

     •	 tìm sản phẩm và nguồn hàng mới.

     •	Tìm nhà cung cấp có các mặt hàng tốt, giá thành hợp lý và phù hợp nhu cầu thị trường.

     •	Tổ chức các sự kiện lớn và nhỏ để tăng liên kết với khách hàng.

     •	Kêu gọi vốn đầu tư từ các công ty khác.
     

 
  **1.2.Hiện trạng nghiệp vụ:**
     
![ho_so_dai_ly_1](https://user-images.githubusercontent.com/48848147/60740753-0e452e80-9f91-11e9-89de-8715fcb42b07.JPG)

![ho_so_dai_ly_2](https://user-images.githubusercontent.com/48848147/60740754-0e452e80-9f91-11e9-8299-532ca928e8e4.JPG)
          
   Tiếp nhận đại lý: 
  -	Tiếp nhận hồ sơ đại lý .
  -	Kiểm tra đại lý thuộc loại 1 hay 2.
  -	Kiểm tra tình trạng quận tiếp nhận đại lý.
  -	Xây dựng đại lý.
  -	Kết thúc tiếp nhận đại lý.

          
![phieu_xuat_hang_1](https://user-images.githubusercontent.com/48848147/60740780-274ddf80-9f91-11e9-955e-5abc49d47f96.JPG)

![phieu_xuat_hang_2](https://user-images.githubusercontent.com/48848147/60740781-274ddf80-9f91-11e9-9144-2376e479ca83.JPG)   
          
  	Lập phiếu xuất hàng:
  -	Kiểm tra loại đại lý.
  -	Kiểm tra tiền nợ của đại lý.
  -	Nếu tiền nợ vượt quá mức quy định, kết thúc lập phiếu xuất hàng.
  -	Nếu tiền nợ chưa vượt quá mức quy định, thống kê mặt hàng cần xuất theo đơn vị tính tương ứng.
  -	Kết thúc lập phiếu xuất hàng.

![tra_cuu_dai_ly_1](https://user-images.githubusercontent.com/48848147/60740782-27e67600-9f91-11e9-884e-1c184b7492a9.JPG)

   Tra cứu đại lý
  
![phieu_thu_tien](https://user-images.githubusercontent.com/48848147/60740783-27e67600-9f91-11e9-8b0c-bab3e81238dc.JPG)

  	Lập phiếu thu tiền:
  -	Tổng hợp và thống kê thông tin đại lý cần lập hóa phiếu.
  -	Kiểm tra số tiền thu.
  -	Nếu tiền thu vượt quá tiền nợ, kết thúc lập hóa phiếu thu tiền.
  -	Nếu tiền thu bé hơn hoặc bằng số tiền nợ, kiểm tra ngày thu và lập hóa phiếu.
  -	Kết thúc lập hóa phiếu thu tiền.
     
![bao_cao_thang](https://user-images.githubusercontent.com/48848147/60740784-27e67600-9f91-11e9-80d4-78344cee504c.JPG)

  	Lập báo cáo tháng: (Văn phòng)
  -	Thống kê phiếu xuất hàng trong tháng.
  -	Tính tổng giá trị các phiếu xuất hàng của từng đại lý.
  -	Tính tỷ lệ giá trị phiếu xuất hàng của mỗi đại lý.
  -	Lập báo cáo doanh số.
  -	Thống kê hóa phiếu thu tiền trong tháng.
  -	Thống kê số nợ đầu tháng.
  -	Thống kê số nợ phát sinh trong tháng.
  -	Từ 2 thông tin trên tính số nợ cuối cùng.
  -	Lập báo cáo công nợ đại lý.
     
![quy_dinh](https://user-images.githubusercontent.com/48848147/60740785-287f0c80-9f91-11e9-9fc1-bb99034282ab.JPG)

  	Thay đổi quy định gồm 1 quy trình (văn phòng)
  -	Nghiệp vụ chủ yếu là của các nhân viên văn phòng yêu cầu có kĩ thuật về công nghệ.

  **1.3.	Hiện trạng tin học:**
     
  	Phần cứng:
  +	Số lượng máy tính: Mỗi văn phòng tối thiểu 15-20 PC. Riêng nhà kho có khoảng 5 máy
  +	Tối thiểu 1 máy server.
  +	Cấu hình: Đáp ứng được các tác vụ yêu cầu.
  +	Có mạng LAN nội bộ công ty và mạng wifi.
  +	Một máy tính tiền và 1 PC cho mỗi đại lý có trang web của nhà quản lý và phân phối đại lý.
  	Phần mềm:
  +	Có một trang web riêng giới thiệu về các sản phẩm và thông tin công ty.
  +	Có hệ quản trị cơ sở dữ liệu SQL & Database.
  +	Đủ các phần mềm cần thiết và có bản quyền.
  +	Sử dụng word và excel để tính toán và lưu thông tin các đại lý và các dữ liệu khác.
  	Tin học:
  +	Tối thiểu 1 nhân viên lập trình, bảo trì, nâng cấp, quản lý web và server.
  +	Một nhân viên chuyên về lắp ráp và sửa chữa máy tính.
     
  	Kết luận: tuần suất làm việc liên tục 8 tiếng một ngày từ thứ 2 đến thứ 6. Nên công ty quản lý và phân phối đại lý cũng đang cần một phần mềm tiện dụng, dễ sử dụng, dễ quản lý, và nhanh chóng sử lý các công việc của công ty. 

  **2.	YÊU CẦU PHẦN MỀM**

  **2.1 Yêu cầu nghiệp vụ:**
  
  ![nghiep_vu_1](https://user-images.githubusercontent.com/48848147/60741230-d3dc9100-9f92-11e9-8cd7-851c577b6c80.JPG)
  
![nghiep_vu_2](https://user-images.githubusercontent.com/48848147/60741231-d3dc9100-9f92-11e9-9540-c9a8cd350605.JPG)

  **2.2	Yêu cầu chất lượng:**
   
  ** Danh sách các yêu cầu chất lượng**
  
 ![chat_luong](https://user-images.githubusercontent.com/48848147/60741232-d4752780-9f92-11e9-8418-eaceadf54c7f.JPG)
  
   ** Bảng trách nhiệm yêu cầu chất lượng**
   
 ![tien_hoa](https://user-images.githubusercontent.com/48848147/60741233-d4752780-9f92-11e9-99b6-76d4742bb0d2.JPG)
  
  **2.3 YÊU CẦU  HỆ THỐNG**
  
  ** Danh sách các yêu cầu hệ thống**
  
![he_thong_1](https://user-images.githubusercontent.com/48848147/60741235-d4752780-9f92-11e9-8ec0-736ca4bd45cb.JPG)

  ** Bảng trách nhiệm yêu cầu hệ thống**
  
![he_thong_2](https://user-images.githubusercontent.com/48848147/60741236-d50dbe00-9f92-11e9-9f23-5df765e59911.JPG)
  
## Chương 2: Phân tích

  **1. FDD:**
     ![HeThongQLDL](https://user-images.githubusercontent.com/48848147/60749523-49615500-9fc5-11e9-926e-444ddd833f4d.png)
     + BẢNG MÔ TẢ CHỨC NĂNG:
     ![chuc_nang_1](https://user-images.githubusercontent.com/48848147/60738984-5ca2ff00-9f8a-11e9-8cae-1310517c5bd2.JPG)
     ![chuc_nang_2](https://user-images.githubusercontent.com/48848147/60739051-9d027d00-9f8a-11e9-8780-06b972127bc7.JPG)

  **2. DFD:**  
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


   Lập phiếu thu tiền
   ![phieu_thu_tien](https://user-images.githubusercontent.com/48848147/60600160-dba50580-9dd9-11e9-8001-2a3208cd5782.JPG) 
   
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


   Báo cáo doanh số
   ![doanh_so](https://user-images.githubusercontent.com/48848147/60600401-45251400-9dda-11e9-91ef-05e258d21a27.JPG)

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


   Báo cáo công nợ
   ![cong_no](https://user-images.githubusercontent.com/48848147/60600414-49e9c800-9dda-11e9-9264-7ea4146bda7e.JPG)
   
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
    

**3. ERD:**   
![New](https://user-images.githubusercontent.com/48848147/60738665-552f2600-9f89-11e9-940c-40e4310d8f94.png)

**4.Class_Diagram(design):
![class_diagram](https://user-images.githubusercontent.com/48848147/60749815-d8706c00-9fc9-11e9-9176-d3cf9dc717d4.JPG)

## Chương 3: Thiết kế
**1. Thiết kế kiến trúc:**

**a.	Mô hình tổng thể kiến trúc:**

 Mô hình 3 lớp MVVM.
![3_lop](https://user-images.githubusercontent.com/48848147/60739665-04213100-9f8d-11e9-8411-6e04fd83d7ef.JPG)

**b.	Danh sách các component:**

**c.	Tương tác/giao tiếp giữa các component:**

**2.	Thiết kế lớp - sơ đồ lớp ở mức thiết kế:**
![so_do_lop](https://user-images.githubusercontent.com/48848147/60739691-1f8c3c00-9f8d-11e9-9d0d-d635bcbe7476.JPG)

**3.	Thiết kế giao diện:**

	Sơ đồ liên kết màn hình: 

![man_hinh_chinh](https://user-images.githubusercontent.com/48848147/60739736-48143600-9f8d-11e9-958d-e55fc0527f70.JPG)

	Mô tả xử lý sự kiện từng màn hình:

+	Màn hình đăng nhập:

![dang_nhap](https://user-images.githubusercontent.com/48848147/60739775-5f532380-9f8d-11e9-8987-834d17b93629.JPG)

•	Màn hình “Đăng nhập”: Nhân viên điền tên đăng nhập và mật khẩu (đã cấp trước đó), sau đó nhấn phím “Đăng nhập” hoặc “Enter” trên bàn phím thì sẽ login được vào màn hình chính. Nếu nhấn nút “Thoát” thì tự động đóng phần mềm

+	Màn hình chính:

![man_hinh_chinh_2](https://user-images.githubusercontent.com/48848147/60739992-2d8e8c80-9f8e-11e9-96c3-f005e22b9e41.JPG)

•	Màn hình “chính”: Dùng để lựa chọn những thao cần thực hiện.

+	Màn hình Hồ sơ đại lý:

![tiep_nhan](https://user-images.githubusercontent.com/48848147/60739999-354e3100-9f8e-11e9-8250-69448bc03770.JPG)

•	Cho phép người dùng thêm , xóa và sửa đại lý và thông tin liên quan.

+	Màn hình phiếu xuất hàng:

![phieu_xuat_hang](https://user-images.githubusercontent.com/48848147/60740007-3bdca880-9f8e-11e9-96f9-132bb80e4b4b.JPG)

•	Cho phép người dùng thêm, xóa và sửa thông tin về mặt hàng và số lượng đã được mua của từng đại lý.

+	Màn hình phiếu thu tiền:

![phieu_thu_tien](https://user-images.githubusercontent.com/48848147/60740017-46973d80-9f8e-11e9-9bbb-06a9d9d63540.JPG)

•	Cho phép người dùng thêm, xóa và sửa thông tin về số tiền thu của từng đại lý.

+	Màn hình danh sách đại lý:

![danh_sach_dai_ly](https://user-images.githubusercontent.com/48848147/60740018-46973d80-9f8e-11e9-9989-fd5af3682ddc.JPG)

•	Cho phép người dùng load thông tin về số nợ của từng đại lý.

+	Màn hình báo cáo doanh số:

![bao_cao_doanh_so](https://user-images.githubusercontent.com/48848147/60740019-46973d80-9f8e-11e9-98e5-4980718cb1d4.JPG)

•	Cho phép người dùng nhập tháng và load những đại lý nào đã xuất hàng , tổng giá trị của số hàng đã xuất và tỷ lệ bao nhiêu phần trăm so với tổng thể của thắng được xem.

+	Công nợ đại lý:

![bao_cao_cong_no](https://user-images.githubusercontent.com/48848147/60740021-472fd400-9f8e-11e9-8593-e799809ce20e.JPG)

•	Cho phép người dùng nhập tháng và load thông tin số nợ đầu tiên , phát sinh và tổng nợ của từng đại lý.

+	Màn hình loại đại lý :

![loai_dai_ly](https://user-images.githubusercontent.com/48848147/60740022-472fd400-9f8e-11e9-924c-51fde2b6b638.JPG)

•	Cho phép người dùng thêm và sửa thông tin loại đại lý  và tiền nợ tối đa của từng loại đại lý.

+	Màn hình quận:

![quan](https://user-images.githubusercontent.com/48848147/60740023-472fd400-9f8e-11e9-83d3-ff546377604d.JPG)

•	Cho phép người dùng sửa thông tin về tên quận và số đại lý tối đa của mỗi quận.

## CHƯƠNG 4: CÀI ĐẶT

**1.	Công nghệ sử dụng: Visual studio 2017, SQL Sever 2012 Express.**

**2.	Vấn đề khi cài đặt:**

+	Thời gian cài đặt visual lâu: hơn 1 tiếng.
+	Phải gỡ cài đặt lại một lần SQL Sever 2012 Express

**3.	Mô tả giải pháp & kỹ thuật:**

+	Cần tìm hiểu và có một chút kiến thức khi cài đặt SQL Server 2012 Express.
+	Phải có mạng và wifi mạnh để download nhanh hơn.
 
># VI. FAQ & Usage:

># IV. Authors:
+    An Xuân Tuấn - 16521355(leader)-phân tích các sơ đồ FDD,DFD,ERD,class_diagram ở dạng thiết kế, tổng hợp và viết báo cáo.

+    Nguyễn Tấn Phát - 16521619-phân tích các sơ đồ FDD,DFD ở dạng thiết kế, chỉnh sửa báo cáo.

+    Lã Tuấn Vinh - 16521439-ERD,class_diagram ERD,class_diagram ở dạng thiết kế, chỉnh sửa báo cáo.

+    Phạm Xuân Linh - 16521717-thiết kế database và code c#.
