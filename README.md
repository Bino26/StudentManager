
# Student Manager App  

A **Student Manager App** built with **Blazor** for the frontend and **ASP.NET Core** for the backend. This application provides a robust platform for managing students, including user registration, account management, and administrative functionalities.  

## Features  

### User Management  
1. **Sign Up**:  
   - Students can sign up for an account to access the application.  

2. **Sign In**:  
   - Secure login system to authenticate users and provide role-based access.  

3. **Invitation-based Registration**:  
   - Admins can send personalized registration links to students.  
   - The link includes a token that enables students to set up their account (username and password).  

4. **Forgot/Reset Password**:  
   - Users can reset their password by receiving a reset link via email.  

### Student Monitoring  
1. **Add Students**:  
   - Admins can register new students in the system.  

2. **Update Student Details**:  
   - Admins can update student information, including name, email, or other relevant details.  

3. **Remove Students**:  
   - Admins can delete students from the system when they are no longer active.  

## Technologies  

### Frontend  
- **Blazor**:  
  - Provides a dynamic and interactive user interface.  
  - Uses MudBlazor components for a clean and responsive design.  

### Backend  
- **ASP.NET Core**:  
  - Handles business logic, authentication, and role-based access control.  
  - Implements RESTful APIs for communication with the frontend.  

### Database  
- **SQL Server**:  
  - Stores all user and student data securely.  
  - Used with **Entity Framework Core** for ORM capabilities.  

### Email Service  
- **MailKit**:  
  - Sends invitation links and password reset emails to users.  

## Getting Started  

1. **Clone the Repository**:  
   ```bash  
   git clone https://github.com/your-repo/student-manager-app.git  
   cd student-manager-app  