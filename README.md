# Dai-ly

## I. Introduce:
Ứng dụng công nghệ thông tin để quản lý trong kinh doanh, công ty và trường học không còn xa lạ nữa.
Lợi ích của phần mềm không chỉ giúp kiểm soát mà còn có thể quản lý các thay đổi trong hệ thống và thực tế.
Phần mềm quản lý đại lý của nhóm:

# II. Build with: 
Softwares you need to install to use and edit system:

Sublime Text 2 - Web design and combine SQL

Download link: https://www.sublimetext.com/2

SQL Server - Manage database

Download link: https://www.microsoft.com/en-us/sql-server/sql-server-downloads
# III. Prerequisites:
# IV. Functions:
  
  1. Agent reception:
    
    Algorithm:
    Step 1: Input data from the user (agencies: name, address, phone, email, day reception).
    Step 2: Connect to database.
    Step 3: Read data from the auxiliary memory.
    Step 4: We check the type of agencies, districts entered that are same with the list of agencies and districts from auxiliary memory or not, and the number of these agencies in each districts is allowed.
    Step 5: If the condition in step 4 is not true, we jump to step 8.
    Step 6: If the condition in step 4 is true, we save the input data to the auxiliary memory.
    Step 7: We export the data to the printer(if requested).
    Srep 8: Close connect to database.
    Step 9: Finish.
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
