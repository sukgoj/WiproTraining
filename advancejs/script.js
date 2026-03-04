// Selecting elements from DOM
const jokeBtn = document.getElementById('fetch-users');
const jokeText = document.getElementById('user-cards');

// Arrow function to fetch data from API
const fetchUsers = () =>
    fetch('https://jsonplaceholder.typicode.com/users')
        .then(response => response.json())
        .then(users => {

            const userCards = users.map(({ id, name, email, phone }) => `
                <div class="card">
                    <h3>${name}</h3>
                    <p><strong>ID:</strong> ${id}</p>
                    <p><strong>Email:</strong> ${email}</p>
                    <p><strong>Phone:</strong> ${phone}</p>
                </div>
            `).join('');

            jokeText.innerHTML = userCards;
        });

// Event listener
jokeBtn.addEventListener('click', fetchUsers);