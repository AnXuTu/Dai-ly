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

># III. BÁO CÁO:
     ## CHƯƠNG 1: HIỆN TRẠNG: 
  
  1.	Khảo sát hiện trạng:
        _ Khảo sát hiện trạng về việc giám sát các hoạt động của các đại lý tạp hóa.
        
     
      1.1.	Hiện trạng tổ chức
       
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
     

 
     1.2.       Hiện trạng nghiệp vụ:
     
     
     
          
         Tiếp nhận đại lý: 
     -	Tiếp nhận hồ sơ đại lý .
     -	Kiểm tra đại lý thuộc loại 1 hay 2.
     -	Kiểm tra tình trạng quận tiếp nhận đại lý.
     -	Xây dựng đại lý.
     -	Kết thúc tiếp nhận đại lý.

          
          
          
     	Lập phiếu xuất hàng:
     -	Kiểm tra loại đại lý.
     -	Kiểm tra tiền nợ của đại lý.
     -	Nếu tiền nợ vượt quá mức quy định, kết thúc lập phiếu xuất hàng.
     -	Nếu tiền nợ chưa vượt quá mức quy định, thống kê mặt hàng cần xuất theo đơn vị tính tương ứng.
     -	Kết thúc lập phiếu xuất hàng.


     	Lập hóa phiếu thu tiền:
     -	Tổng hợp và thống kê thông tin đại lý cần lập hóa phiếu.
     -	Kiểm tra số tiền thu.
     -	Nếu tiền thu vượt quá tiền nợ, kết thúc lập hóa phiếu thu tiền.
     -	Nếu tiền thu bé hơn hoặc bằng số tiền nợ, kiểm tra ngày thu và lập hóa phiếu.
     -	Kết thúc lập hóa phiếu thu tiền.
     
     
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
     
     
     	Thay đổi quy định gồm 1 quy trình (văn phòng)
     -	Nghiệp vụ chủ yếu là của các nhân viên văn phòng yêu cầu có kĩ thuật về công nghệ.

     1.3.	     Hiện trạng tin học:
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


# V. Example:   
# VI. FAQ & Usage:
# VII. Contributing:
# IV. Authors:
An Xuân Tuấn - 16521355

Nguyễn Tấn Phát - 16521619

Lã Tuấn Vinh - 16521439

Phạm Xuân Linh - 16521717
