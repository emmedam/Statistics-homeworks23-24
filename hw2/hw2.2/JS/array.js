let array = [];

        function generateArray() {
            const arrayLength = parseInt(document.getElementById('arrayLength').value);
            array = Array.from({ length: arrayLength }, () => Math.floor(Math.random() * 100));
            displayArray();
        }

        function displayArray() {
            document.getElementById('resultArr').innerHTML = `Array: [${array.join(', ')}]`;
        }

        function addElementArray() {
            const element = document.getElementById('addElement').value;
            array.push(element);
            displayArray();
        }

        function deleteElementArray() {
            const element = document.getElementById('deleteElement').value;
            const index = array.indexOf(element);
            if (index !== -1) {
                array.splice(index, 1);
                displayArray();
            } else {
                document.getElementById('result').innerHTML = `Element not found in the array.`;
            }
        }

        function searchElementArray() {
            const element = document.getElementById('searchElement').value;
            const index = array.indexOf(element);
            if (index !== -1) {
                document.getElementById('result').innerHTML = `Element found at index ${index}.`;
            } else {
                document.getElementById('result').innerHTML = `Element not found in the array.`;
            }
        }