# library
Student project - Create simple application with connectionless database operations.

Main functionality should be merged into develop branch.

# Authors
- Konrad Ciałkowski
- Kacper Czyrzniejewski

# How to use
After compiling the program, a welcome window is displayed. Upon navigating to the "Books" tab, we see a table consisting of available books in the library.

# Add Book
To add a new book along with its number of copies, fill in the fields below the table and then click the "Add book" button.

# Change Quantity
To change the number of copies of a particular book, click the "Quantity" button next to the appropriate row. After clicking, a window with the name of the selected book will open. There we can update the number of copies.

# Rent Book
To borrow a particular book, click the "Rent" button next to the appropriate row. After clicking, a new window will appear. There we enter the details of the customer who wants to borrow the book, and then confirm everything with the "Rent for this customer" button..

# Rent Back
To return a borrowed book in the "Rent" window, simply click the "Rent Back" button in the appropriate row. The cost of the fee is automatically calculated.

# Business rules
- After 89 days without rent back, customer will be fined 100 PLN
- An information will be sent to the customer's email address with rent description
