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

Microsoft Visual Studio - Xây dựng phần mềm

Download link: 

SQL Server - quản lý cơ sở dữ liệu

Download link: 

># IV. Functions:
  
  1. Tiếp nhận đại lý:
  
    Thuật toán:
     Bước 1: Nhập dữ liệu từ người dùng (cơ quan: tên, địa chỉ, điện thoại, email, tiếp nhận ngày).
     Bước 2: Kết nối với cơ sở dữ liệu.
     Bước 3: Đọc dữ liệu từ bộ nhớ phụ.
     Bước 4: kiểm tra loại cơ quan, quận được nhập có giống với danh sách các cơ quan và quận từ bộ nhớ phụ hay không, và số lượng đạ lý cho phép này ở mỗi quận.
     Bước 5: Nếu điều kiện ở bước 4 không đúng, chúng ta chuyển sang bước 8.
     Bước 6: Nếu điều kiện ở bước 4 là đúng, chúng ta lưu dữ liệu đầu vào vào bộ nhớ phụ.
     Bước 7: Chúng tôi xuất dữ liệu sang máy in (nếu được yêu cầu).
     Srep 8: Đóng kết nối với cơ sở dữ liệu.
     Bước 9: Hoàn tất.
  2. Set up delivery notes:
      
    Algorithm:
    Step 1: Input data from the user(agencies: name, products, unit count, number of product, price).
    Step 2: Connect to database.
    Step 3: Read data from the auxiliary memory.
    Step 4: Check the type of products and unit count entered that are same with the type of products and unit count from auxiliary memory or not.
    Step 5: If the condition in step 4 is not true, we jump to step 9.
    Step 6: If the condition in step 4 is true, we save the money to the auxiliary memory that the agencies need to pay.
    step 7: Return the input data and date of issue of delivery note for user
    Step 8: We export the data to the printer.
    Srep 9: Close connect to database.
    Step 10: Finish.
   3. Lookup the agencies:
    
    Algorithm:
    Step 1: Input data from the user(agencies: name of ditricts or agencies).
    Step 2: Connect to database.
    Step 3: Read data from the auxiliary memory.
    Step 4: Check the name of agencies or districts entered that are in the list of auxiliary memory.
    Step 5: If the condition in step 4 is not true, we jump to step 8.
    step 6: Return the imformation of the agencies that we are needing for user
    Step 7: We export the data to the printer(if needed).
    Srep 8: Close connect to database.
    Step 9: Finish.
   4. set up a receipt
    
    Algorithm:
    Step 1: Input data from the user(agencies: name of address and agencies, phone, email, the receipt).
    Step 2: Connect to database.
    Step 3: Read data from the auxiliary memory.
    Step 4: Check the name of agencies entered that are in the list of auxiliary memory, check the regulation of the receipted money with the money in debt is appropriate or not, and maximum amount of debt.
    Step 5: If the condition in step 4 is not true, we jump to step 8.
    step 6: Return the receipted money of the agencies for user
    Step 7: We export the data to the printer(if needed).
    Srep 8: Close connect to database.
    Step 9: Finish.
   5. Sales report
   
    Algorithm:
    Step 1: Input data from the user(the month need reporting).
    Step 2: Connect to database.
    Step 3: Read data from the auxiliary memory.
    Step 4: Check the month was entered that is appropriate or not
    Step 5: If the condition in step 4 is not true, we jump to step 8.
    step 6: Return the list of agencies, the number of... , total values, ratio and the month need reporting.
    Step 7: We export the data to the printer(if needed).
    Srep 8: Close connect to database.
    Step 9: Finish.
   6. Debt report
   
    Algorithm:
    Step 1: Input data from the user(the month need reporting).
    Step 2: Connect to database.
    Step 3: Read data from the auxiliary memory.
    Step 4: Check the month was entered that is appropriate or not
    Step 5: If the condition in step 4 is not true, we jump to step 8.
    step 6: Return the list of agencies, the first, incurred, last debt and the month need reporting.
    Step 7: We export the data to the printer(if needed).
    Srep 8: Close connect to database.
    Step 9: Finish.
# V. Example:   
# VI. FAQ & Usage:
# VII. Contributing:
# IV. Authors:
An Xuân Tuấn - 16521355

Nguyễn Tấn Phát - 16521619

Lã Tuấn Vinh - 16521439

Phạm Xuân Linh - 16521717
