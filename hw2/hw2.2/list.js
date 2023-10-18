let list = [];

        function generateList() {
            const listLength = parseInt(document.getElementById('listLength').value);
            list = Array.from({ length: listLength }, () => Math.floor(Math.random() * 100));
            displayList();
        }

        function displayList() {
            document.getElementById('resultList').innerHTML = `List: [${list.join(', ')}]`;
        }

        function addElement() {
            const element = document.getElementById('addElement').value;
            list.push(element);
            displayList();
        }

        function deleteElement() {
            const element = document.getElementById('deleteElement').value;
            const index = list.indexOf(element);
            if (index !== -1) {
                list.splice(index, 1);
                displayList();
            } else {
                document.getElementById('result').innerHTML = `Element not found in the list.`;
            }
        }

        function searchElement() {
            const element = document.getElementById('searchElement').value;
            const index = list.indexOf(element);
            if (index !== -1) {
                document.getElementById('result').innerHTML = `Element found at index ${index}.`;
            } else {
                document.getElementById('result').innerHTML = `Element not found in the list.`;
            }
        }