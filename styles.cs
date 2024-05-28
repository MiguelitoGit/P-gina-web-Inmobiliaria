* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

body, html {
    height: 100%;
    font-family: 'Arial', sans-serif;
}

.navbar {
    display: flex;
    justify-content: space-between;
    align-items: center;
    background-color: #333;
    padding: 10px 20px;
    color: white;
    position: fixed;
    width: 100%;
    top: 0;
    z-index: 1000;
}

.navbar .logo {
    font-size: 24px;
    font-weight: bold;
}

.navbar .nav-links {
    list-style: none;
    display: flex;
    gap: 20px;
}

.navbar .nav-links li {
    display: inline;
}

.navbar .nav-links li a, .navbar .login-btn {
    color: white;
    text-decoration: none;
    padding: 10px 15px;
    border: 1px solid transparent;
    border-radius: 4px;
    transition: all 0.3s ease;
}

.navbar .login-btn {
    background-color: #6c63ff;
    cursor: pointer;
}

.navbar .nav-links li a:hover, .navbar .login-btn:hover {
    background-color: #575757;
}

.content {
    background: url('https://tangible.pe/blog/wp-content/uploads/2022/06/inmobiliarias-en-lima-Besco-Inmobiliaria-1024x683.jpg') no-repeat center center/cover;
    height: calc(100vh - 50px);
    display: flex;
    align-items: center;
    justify-content: center;
    color: white;
    text-align: center;
    margin-top: 50px;
}

.content .info h1 {
    font-size: 48px;
    margin-bottom: 20px;
}

.content .info p {
    font-size: 24px;
}

.scroll-down {
    position: absolute;
    bottom: 20px;
    left: 50%;
    transform: translateX(-50%);
}

.scroll-down button {
    background: none;
    border: none;
    font-size: 48px;
    color: white;
    cursor: pointer;
}

#more-info {
    padding: 50px;
    background-color: #f4f4f4;
    text-align: center;
}

#modal {
    display: none;
    position: fixed;
    z-index: 1;
    left: 0;
    top: 0;
    width: 100%;
    height: 100%;
    overflow: auto;
    background-color: rgba(0,0,0,0.5);
    align-items: center;
    justify-content: center;
}

.modal-content {
    background-color: #fff;
    margin: auto;
    padding: 20px;
    border: 1px solid #888;
    width: 300px;
    border-radius: 10px;
    position: relative;
}

.close-btn {
    position: absolute;
    top: 10px;
    right: 10px;
    font-size: 28px;
    cursor: pointer;
}

.modal-content form {
    display: flex;
    flex-direction: column;
}

.modal-content form label {
    margin-bottom: 5px;
    color: #666;
}

.modal-content form input {
    padding: 10px;
    margin-bottom: 20px;
    border: 1px solid #ccc;
    border-radius: 4px;
}

.modal-content form button {
    padding: 10px;
    background-color: #6c63ff;
    color: white;
    border: none;
    border-radius: 4px;
    cursor: pointer;
}

.modal-content form button:hover {
    background-color: #5a54d6;
}
