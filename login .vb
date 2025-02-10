<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>HomeScape Login</title>
    <style>
        :root {
            --primary-color: #ff5a3c;
            --text-color: #0b2c3c;
            --link-color: #0f3460;
            --error-color: #e74c3c;
            --success-color: #2ecc71;
        }

        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
            font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, sans-serif;
        }

        body {
            min-height: 100vh;
            display: flex;
            align-items: center;
            justify-content: center;
            padding: 1rem;
            background-color: #ffffff;
        }

        .container {
            width: 100%;
            max-width: 400px;
        }

        .title {
            text-align: center;
            font-size: 1.875rem;
            font-weight: 600;
            margin-bottom: 2rem;
            color: var(--text-color);
        }

        .title em {
            font-style: italic;
        }

        .card {
            background: #ffffff;
            border-radius: 8px;
            padding: 2rem;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            border: 1px solid rgba(11, 44, 60, 0.1);
        }

        .form-group {
            margin-bottom: 1.5rem;
            position: relative;
        }

        label {
            display: block;
            margin-bottom: 0.5rem;
            color: var(--text-color);
            font-size: 0.875rem;
        }

        input {
            width: 100%;
            padding: 0.75rem;
            border: 1px solid var(--primary-color);
            border-radius: 6px;
            font-size: 0.875rem;
            outline: none;
            transition: border-color 0.2s, box-shadow 0.2s;
        }

        input:focus {
            box-shadow: 0 0 0 2px rgba(255, 90, 60, 0.2);
        }

        .password-toggle {
            position: absolute;
            right: 10px;
            top: 38px;
            cursor: pointer;
            color: var(--text-color);
        }

        .register-text {
            text-align: center;
            font-size: 0.875rem;
            margin: 1rem 0;
            color: var(--text-color);
        }

        .register-text a {
            color: var(--link-color);
            text-decoration: none;
        }

        .register-text a:hover {
            text-decoration: underline;
        }

        button {
            width: 100%;
            padding: 0.75rem;
            background-color: var(--primary-color);
            color: white;
            border: none;
            border-radius: 6px;
            font-size: 0.875rem;
            cursor: pointer;
            transition: background-color 0.2s;
        }

        button:hover {
            background-color: #e54935;
        }

        .error {
            color: var(--error-color);
            font-size: 0.75rem;
            margin-top: 0.25rem;
        }

        .success {
            color: var(--success-color);
            font-size: 0.875rem;
            text-align: center;
            margin-top: 1rem;
        }

        @media (max-width: 480px) {
            .card {
                padding: 1.5rem;
            }

            .title {
                font-size: 1.5rem;
            }
        }
    </style>
</head>
<body>
    <div class="container">
        <h1 class="title">Login to <em>HomeScape</em></h1>
        <div class="card">
            <form id="loginForm">
                <div class="form-group">
                    <label for="email">Email</label>
                    <input 
                        type="email" 
                        id="email" 
                        placeholder="john@gmail.com" 
                        required
                    >
                    <div class="error" id="emailError"></div>
                </div>
                <div class="form-group">
                    <label for="password">Password</label>
                    <input 
                        type="password" 
                        id="password" 
                        placeholder="********" 
                        required
                    >
                    <span class="password-toggle" id="passwordToggle">👁️</span>
                    <div class="error" id="passwordError"></div>
                </div>
                <div class="register-text">
                    Don't have a HomeScape account? 
                    <a href="/register">Register</a>
                </div>
                <button type="submit">Login</button>
            </form>
            <div class="success" id="successMessage"></div>
        </div>
    </div>

    <script>
        document.addEventListener('DOMContentLoaded', function() {
            const form = document.getElementById('loginForm');
            const email = document.getElementById('email');
            const password = document.getElementById('password');
            const emailError = document.getElementById('emailError');
            const passwordError = document.getElementById('passwordError');
            const successMessage = document.getElementById('successMessage');
            const passwordToggle = document.getElementById('passwordToggle');

            // Show/hide password
            passwordToggle.addEventListener('click', function() {
                if (password.type === 'password') {
                    password.type = 'text';
                    passwordToggle.textContent = '🔒';
                } else {
                    password.type = 'password';
                    passwordToggle.textContent = '👁️';
                }
            });

            // Form submission
            form.addEventListener('submit', function(e) {
                e.preventDefault();
                
                // Reset error messages
                emailError.textContent = '';
                passwordError.textContent = '';
                successMessage.textContent = '';

                // Validate email
                if (!email.value.includes('@')) {
                    emailError.textContent = 'Please enter a valid email address.';
                    return;
                }

                // Validate password
                if (password.value.length < 8) {
                    passwordError.textContent = 'Password must be at least 8 characters long.';
                    return;
                }

                // Mock login process
                setTimeout(() => {
                    successMessage.textContent = 'Login successful! Redirecting...';
                    form.reset();
                    // In a real app, you would redirect here or perform further actions
                }, 1000);
            });
        });
    </script>
</body>
</html>