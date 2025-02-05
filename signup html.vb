<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>HomeScape - Create Account</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="container">
        <div class="form-wrapper">
            <h1>Create a new <span class="italic">HomeScape</span> Account</h1>

            <form class="signup-form" onsubmit="handleSubmit(event)">
                <div class="form-group">
                    <label for="name">Name</label>
                    <input 
                        type="text" 
                        id="name" 
                        placeholder="John Doe" 
                        required
                    >
                </div>

                <div class="form-group">
                    <label for="username">Username</label>
                    <input 
                        type="text" 
                        id="username" 
                        placeholder="JohnDoe_12" 
                        required
                    >
                </div>

                <div class="form-group">
                    <label for="email">Email</label>
                    <input 
                        type="email" 
                        id="email" 
                        placeholder="john@gmail.com" 
                        required
                    >
                </div>

                <div class="form-group">
                    <label for="password">Password</label>
                    <input 
                        type="password" 
                        id="password" 
                        placeholder="********" 
                        required
                    >
                </div>

                <div class="login-link">
                    Already have a HomeScape Account? 
                    <a href="/login">Login</a>
                </div>

                <button type="submit" class="submit-button">
                    Create Account
                </button>
            </form>
        </div>
    </div>

    <script>
        function handleSubmit(event) {
            event.preventDefault();
            
            const formData = {
                name: document.getElementById('name').value,
                username: document.getElementById('username').value,
                email: document.getElementById('email').value,
                password: document.getElementById('password').value
            };
            
            console.log('Form submitted:', formData);
            // Add your form submission logic here
        }
    </script>
</body>
</html>