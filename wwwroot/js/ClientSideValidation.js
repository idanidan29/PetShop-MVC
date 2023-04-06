//name
const nameInput = document.getElementById('name');
const nameError = document.getElementById('name-error');

nameInput.addEventListener('input', function () {
    const name = nameInput.value.trim();
    if (name.length < 2) {
        nameError.textContent = 'Name must be at least 2 characters';
        nameInput.setCustomValidity('Name must be at least 2 characters');
    } else if (!/^[a-zA-Z\s]*$/.test(name)) {
        nameError.textContent = 'Name can only contain letters and spaces';
        nameInput.setCustomValidity('Name can only contain letters and spaces');
    } else {
        nameError.textContent = '';
        nameInput.setCustomValidity('');
    }
});
//age
const ageInput = document.getElementById('age');
const ageError = document.getElementById('age-error');

ageInput.addEventListener('input', function () {
    const age = parseInt(ageInput.value);
    if (isNaN(age)) {
        ageError.textContent = 'Age must be a number';
        ageInput.setCustomValidity('Age must be a number');
    } else if (age < 1 || age >= 500) {
        ageError.textContent = 'Age must be between 1 and 500';
        ageInput.setCustomValidity('Age must be between 1 and 500');
    } else {
        ageError.textContent = '';
        ageInput.setCustomValidity('');
    }
});
//description
const descriptionInput = document.getElementById('description');
const descriptionError = document.getElementById('description-error');

descriptionInput.addEventListener('input', function () {
    const description = descriptionInput.value.trim();
    if (description.length < 3) {
        descriptionError.textContent = 'Description must be at least 3 characters';
        descriptionInput.setCustomValidity('Description must be at least 3 characters');
    } else if (description.length > 400) {
        descriptionError.textContent = 'Description must be no more than 400 characters';
        descriptionInput.setCustomValidity('Description must be no more than 400 characters');
    } else {
        descriptionError.textContent = '';
        descriptionInput.setCustomValidity('');
    }
});
//image adress
const imageInput = document.getElementById('png-image-address');
const imageError = document.getElementById('png-image-address-error');


imageInput.addEventListener('input', function () {
    const description = imageInput.value.trim();
    if (description.length === 0) {
        imageError.textContent = 'PNG Image Address is required.';
        imageInput.setCustomValidity('PNG Image Address is required.');
    }
    var isValid = /\.jpe?g$/i.test(imageInput.value);
    if (!isValid)
    {
        imageError.textContent = 'PNG Image Address is required.';
        imageInput.setCustomValidity('PNG Image Address is required.');
    }
    else {
        imageError.textContent = '';
        imageInput.setCustomValidity('');
    }
});

















