WORK#2/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <div class="app">
        <div class="app__flex">
            <div class="board">
                <div class="row first-row">
                    <input type="text" class="board__input">
                    <input type="text" class="board__input">
                    <input type="text" class="board__input">
                    <input type="text" class="board__input">
                    <input type="text" class="board__input">
                </div>
                <div class="row second-row">
                    <input type="text" class="board__input">
                    <input type="text" class="board__input">
                    <input type="text" class="board__input">
                    <input type="text" class="board__input">
                    <input type="text" class="board__input">
                </div>
                <div class="row third-row">
                    <input type="text" class="board__input">
                    <input type="text" class="board__input">
                    <input type="text" class="board__input">
                    <input type="text" class="board__input">
                    <input type="text" class="board__input">
                </div>
                <div class="row forth-row">
                    <input type="text" class="board__input">
                    <input type="text" class="board__input">
                    <input type="text" class="board__input">
                    <input type="text" class="board__input">
                    <input type="text" class="board__input">
                </div>
            </div>
            <div class="connections">
                <div class="connections__inputs">
                    <div class="row__input_text">
                        <h3>Enter Element 1</h3>
                        <h3>Enter Element 2</h3>
                        <h3>Enter count of connections</h3>
                    </div>
                    <!-- <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="1">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="4">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="1">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="1">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="5">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="1">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="4">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="7">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="2">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="4">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="6">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="1">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="7">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="8">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="2">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="8">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="5">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="3">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="5">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="2">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="1">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="2">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="10">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="1">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="2">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="3">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="1">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="3">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="11">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="1">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="3">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="6">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="1">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="10">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="12">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="1">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="11">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="9">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="1">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="6">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="12">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="1">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="9">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="12">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="2">
                    </div> -->
                    <!-- --------------------------------------------------- -->
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="12">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="11">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="2">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="11">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="10">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="1">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="10">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="3">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="1">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="10">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="2">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="1">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="1">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="2">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="3">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="12">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="6">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="1">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="3">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="5">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="1">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="5">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="7">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="2">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="7">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="9">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="1">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="9">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="8">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="2">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="5">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="4">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="1">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="7">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="4">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="1">
                    </div>
                    <div class="row__input">
                        <input class="row_text_input main" type="text" placeholder="Enter Element 1" value="8">
                        <input class="row_text_input second" type="text" placeholder="Enter Element 2" value="6">
                        <input class="row_text_input third" type="text" placeholder="Enter count of connections" value="1">
                    </div>
                </div>
                <button class="add_btn">Add Row</button>
            </div>
        </div>
        
        <button class="btn">Submit</button>
    </div>
    <script src="script.js"></script>
</body>
</html>

"use strict"

const btnElem = document.querySelector('.btn');
const btnElemAdd = document.querySelector('.add_btn');

btnElem.addEventListener('click', () => {
    const arrBoard = creatеMatrix(4, 5);

    fillMatrixByNumber(0, arrBoard);

    syncMatrixWithBoard(arrBoard, 5);

    const arrValues = getArrayOfValuesBoard(arrBoard);

    // const formedConnections = getArrayFromConnections(arrValues);

    // const staticElem = findNeededItem(formedConnections, arrValues, arrBoard);

    // arrValues.push(staticElem);
    

    for (let i = 0; i < 9; i++) {
        const formedConnections = getArrayFromConnections(arrValues);

        const staticElem = findNeededItem(formedConnections, arrValues, arrBoard);
    
        arrValues.push(staticElem);
    }

    console.log('REST', arrValues);
});

btnElemAdd.addEventListener('click', () => {
    const cloneElemRow = document.querySelector('.row__input').cloneNode(true);
    
    document.querySelector('.connections__inputs').append(cloneElemRow);
});

const creatеMatrix = (sizeX, sizeY) => {
    const arr = [];

    for (let i = 0; i < sizeX; i++) {   
        arr.push([]);
        for (let j = 0; j < sizeY; j++) {
            arr[i].push([]);
        }
    }

    return arr;
}

const fillMatrixByNumber = (numb, arr) => {
    for (let i = 0; i < arr.length; i++) {
        arr[i].fill(numb);
    }
}

const syncMatrixWithBoard = (arr, rowLong) => {
    const inputElems = document.querySelectorAll('.board__input');
    let rowNumb = 0;
    let elemNumb = 0;

    for (let i = 0; i < inputElems.length; i++) {
        if(i % rowLong === 0 && i !== 0) {
            rowNumb++;
            elemNumb = 0;
        }
        if(Number(inputElems[i].value) !== 0) {
            arr[rowNumb][elemNumb] = Number(inputElems[i].value);
        }
        elemNumb++;
    }

    console.log(arr);
}

const getArrayOfValuesBoard = (arr) => {
    const arrayValues = [];

    for (let i = 0; i < arr.length; i++) {
        for (let g = 0; g < arr[i].length; g++) {
            if(arr[i][g] !== 0) {
                arrayValues.push(arr[i][g]);
            }
        }
    }

    return arrayValues;
}

const getArrayFromConnections = (arrStatic) => {
    const mainElemArr = [];
    const secondElemArr = [];
    const connectionArr = [];

    const arrMain = document.querySelectorAll('.main');
    const arrSecond = document.querySelectorAll('.second');
    const arrThird = document.querySelectorAll('.third');

    arrMain.forEach((element) => {
        mainElemArr.push(Number(element.value));
    });

    arrSecond.forEach((element) => {
        secondElemArr.push(Number(element.value));
    });

    arrThird.forEach((element) => {
        connectionArr.push(Number(element.value));
    });

    return countNumberForBoard(mainElemArr, secondElemArr, connectionArr, arrStatic);
}

const countNumberForBoard = (arr1, arr2, arr3, arrStatic) => {
    const resultTableConnections = new Map();

    for (let g = 1; g <= 12; g++) {

        let staticData = 0;
        let dynamicData = 0;
        let staticElem = [0, 0];

        for (let j = 0; j < arr1.length; j++) {
            const elemMain = arr1[j];
            const secondElem = arr2[j];
            const elemConnect = arr3[j];

            if(elemMain === g) {
                if (arrStatic.includes(elemMain) && arrStatic.includes(secondElem) || arrStatic.includes(elemMain)) {
                    break;
                } else if(!arrStatic.includes(elemMain) && arrStatic.includes(secondElem)) {
                    staticData += elemConnect;
                    if(staticElem[0] !== 0) {
                        if(elemConnect > staticElem[1]) {
                            staticElem[0] = secondElem;
                            staticElem[1] = elemConnect;
                        }
                    } else {
                        staticElem[0] = secondElem;
                        staticElem[1] = elemConnect;
                    }
                } else if(!arrStatic.includes(elemMain) && !arrStatic.includes(secondElem)) {
                    dynamicData += elemConnect;
                }
            }
        }

        for (let j = 0; j < arr2.length; j++) {
            const elemMain = arr2[j];
            const secondElem = arr1[j];
            const elemConnect = arr3[j];

            if(elemMain === g) {
                if (arrStatic.includes(elemMain) && arrStatic.includes(secondElem) || arrStatic.includes(elemMain)) {
                    break;
                } else if(!arrStatic.includes(elemMain) && arrStatic.includes(secondElem)) {
                    staticData += elemConnect;
                    if(staticElem[0] !== 0) {
                        if(elemConnect > staticElem[1]) {
                            staticElem[0] = secondElem;
                            staticElem[1] = elemConnect;
                        }
                    } else {
                        staticElem[0] = secondElem;
                        staticElem[1] = elemConnect;
                    }
                } else if(!arrStatic.includes(elemMain) && !arrStatic.includes(secondElem)) {
                    dynamicData += elemConnect;
                }
            }

            if(j === arr2.length - 1 && !arrStatic.includes(g) && !arrStatic.includes(g) ) {
                // console.log(staticElem[0]);
                resultTableConnections.set(g, [staticData, dynamicData, staticElem[0]]);
            }
        }


    }

    return resultTableConnections;
}

const findNeededItem = (arr, arrStatic, boardArr) => {
    let indexElem = 0;
    let maxStatic = 0;
    let putItem = 0;

    console.log('CALL');

    // console.log(arrStatic);
    console.log(arr);

    for (let i = 1; i <= 12; i++) {
        if(!arrStatic.includes(i)) {
            if(i === 1) {
                indexElem = i;
                putItem = arr.get(i)[2];
                maxStatic = arr.get(i)[0];
            } else {
                if(maxStatic < arr.get(i)[0]) {
                    maxStatic = arr.get(i)[0];
                    indexElem = i;
                    putItem = arr.get(i)[2];
                }
            }
        }
    }

    console.log(`Index ${indexElem}, Static ${maxStatic}, Where to put ${putItem}`);

    return setItemToBoard(indexElem, putItem, boardArr);
}

const setItemToBoard = (indexElem, putItem, arrBoard) => {
    // console.log('setItemToBoard ITEM ', indexElem);
    // console.log('setItemToBoard PUT ', putItem);
    // console.log('setItemToBoard arrBoard ', arrBoard);

    for (let i = 0; i < arrBoard.length; i++) {
        for (let j = 0; j < arrBoard[i].length; j++) {
            if(arrBoard[i][j] === putItem) {
                if(j - 1 >= 4 && arrBoard[i][j - 1] === 0) {
                    arrBoard[i][j - 1] = indexElem;
                    break;
                } else if(i - 1 >= 0 && arrBoard[i - 1][j] === 0) {
                    arrBoard[i - 1][j] = indexElem;
                    break;
                } else if (j + 1 <= 4 && arrBoard[i][j + 1] === 0) {
                    arrBoard[i][j + 1] = indexElem;
                    break;
                } else if(i + 1 <= 3 && arrBoard[i + 1][j] === 0) {
                    arrBoard[i + 1][j] = indexElem;
                    break;
                } 
            }
        }
    }

    console.log(arrBoard);
    syncBackToBoard(arrBoard);
    return indexElem;
}

const syncBackToBoard = (arrBoard) => {
    const allInputs = document.querySelectorAll('.board__input');
    const arr = []; 

    allInputs.forEach(element => {
        arr.push(element);
    });

    console.log(arrBoard);

    for (let i = 0; i < arrBoard.length; i++) {
        for (let j = 0; j < arrBoard[i].length; j++) {
            const sum = (i * 5) + (j);

            // if (arrBoard[i][j] == 0) {
                // console.log(arrBoard[i][j], 'NUMBER');
                arr[sum].value = arrBoard[i][j];
            // }

        }
    }
}

body, html {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

.app {
    margin-top: 100px;
}

.app__flex {
    display: flex;
    justify-content: center;
}

.board {
    width: 50%;
    display: flex;
    flex-direction: column;
    justify-content: center
}

.row {
    display: flex;
    justify-content: center;
}

.board__input {
    width: 100px;
    height: 100px;
    text-align: center;
    font-size: 24px;
}

.btn {
    display: block;
    background-color: silver;
    padding: 20px 80px;
    border: 1px solid black;
    cursor: pointer;
    font-size: 20px;
    margin: 0 auto;
    margin-top: 50px;
}

.row_text_input {
    padding: 5px 10px;
}

.add_btn {
    margin-top: 20px;
    padding: 5px;
}

.row__input {
    margin-top: 10px;
}

.row__input_text {
    display: flex;
    justify-content: space-between;
}

WORK#3/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sapr_3
{
    internal class Ray
    {
        public int coordY { get; set; }
        public int coordX { get; set; }
        public Direction Main { get; set; }
        public Direction Add { get; set; }
        public bool canTrace = true;
    }
    enum Direction
    {
        Left,
        Up,
        Right,
        Down
    }
    public class Cell
    {
        public int Value { get; set; }
        public string StringValue { get; set; }
        public int WaveNumber { get; set; }
    }
    internal class Program
    {
        static string[] letters = new string[7] { "A", "B", "C", "D", "E", "F", "H" };
        static Cell[,] baseBoard;
        static int[,] baseCMatrix, tempCMatrix;
        static List<Cell[,]> resultBoards;
        static Dictionary<string, int> letterNumberConvertion = new Dictionary<string, int>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Initialize();
            EnterData();

            // для кешування
            WaveAlgorithm();
            RayAlgorithm();


            Stopwatch stopWatch = new Stopwatch();
            TimeSpan ts;
            string elapsedTime;

            stopWatch.Start();
            WaveAlgorithm();
            stopWatch.Stop();

            ts = stopWatch.Elapsed;
            elapsedTime = ts.TotalMilliseconds.ToString();
            Console.Clear();
            ShowResult(resultBoards, "Algorith Li", elapsedTime);

            stopWatch.Restart();
            RayAlgorithm();
            stopWatch.Stop();

            ts = stopWatch.Elapsed;
            elapsedTime = ts.TotalMilliseconds.ToString();
            ShowResult(resultBoards, "Shuning algorith", elapsedTime);

            Console.ReadLine();
        }
        static void Initialize()
        {
            baseBoard = new Cell[11, 9];
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    baseBoard[i, j] = new Cell() { Value = 0 };
                }
            }

            baseCMatrix = new int[7, 7];
            tempCMatrix = new int[7, 7];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    baseCMatrix[i, j] = 0;
                    tempCMatrix[i, j] = 0;
                }
            }

            letterNumberConvertion.Add("A", 1);
            letterNumberConvertion.Add("B", 2);
            letterNumberConvertion.Add("C", 3);
            letterNumberConvertion.Add("D", 4);
            letterNumberConvertion.Add("E", 5);
            letterNumberConvertion.Add("F", 6);
            letterNumberConvertion.Add("H", 7);

        }
        static void EnterData()
        {
            string data;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Введіть елемент та його координати у форматі \"Elem-Ycoord:Xcoord\"");
                data = Console.ReadLine();

                string[] datastrings = data.Split('-');
                if (data.Length > 4)
                {
                    string[] numberstrings = datastrings[1].Split(':');
                    if (int.TryParse(numberstrings[0].ToString(), out int y) && int.TryParse(numberstrings[1].ToString(), out int x))
                    {
                        baseBoard[y - 1, x - 1].StringValue = datastrings[0];
                        baseBoard[y - 1, x - 1].Value = int.MaxValue;
                    }
                }
                else
                    i--;
                Console.Clear();
            }

            do
            {
                Console.WriteLine($"Введіть зв'язок між елементами для схеми з'єднань у форматі \"елемент-елемент\" та натисніть enter. Щоб виконати розрахунки введіть \"OK\".");
                data = Console.ReadLine();
                if (data == "OK" || data == "ОК")
                    break;
                string[] datastrings = data.Split('-');
                if (data.Length > 2)
                {
                    try
                    {
                        int i = letterNumberConvertion[datastrings[0]] - 1;
                        int j = letterNumberConvertion[datastrings[1]] - 1;
                        baseCMatrix[i, j]++;
                        baseCMatrix[j, i]++;
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("Ввід відхилено. Повторіть спробу");
                        Console.ReadLine();
                    }
                }
                Console.Clear();
            }
            while (true);
            Console.Clear();
        }
        static private void WaveAlgorithm()
        {
            SetUp();
            bool changeElement = true;
            string first = "", second;
            int firstNumber = 0, layer, pathNumber = 1;
            while (true)
            {
                layer = 0;

                if (changeElement) // зміна першого елемента
                {
                    firstNumber = FindFirstElement(out first);
                    changeElement = false;

                    if (first == "") // трасування закінчено
                        return;
                }

                FindSecondElement(out second, firstNumber);

                if (second == "") // елемент відрасовано
                {
                    changeElement = true;
                    continue;
                }

                FindCoordinatesOfElement(first, out int y1, out int x1);
                FindCoordinatesOfElement(second, out int y2, out int x2);
                int step;
                while (!ShareWave((y1, x1), (y2, x2), layer, out step)) // поки не знайдеться шлях
                {
                    layer++;
                    if (resultBoards.Count <= layer)
                        CreateNewBoard(layer);
                }
                MakeSimplePath((y1, x1), (y2, x2), layer, step, pathNumber);
                pathNumber++;
                ClearWaves();
            }

        }
        static private void RayAlgorithm()
        {
            SetUp();
            bool changeElement = true;
            string first = "", second;
            int firstNumber = 0, layer, pathNumber = 1;
            while (true)
            {
                layer = 0;

                if (changeElement) // зміна першого елемента
                {
                    firstNumber = FindFirstElement(out first);
                    changeElement = false;

                    if (first == "") // трасування закінчено
                        return;
                }

                FindSecondElement(out second, firstNumber);

                if (second == "") // елемент відрасовано
                {
                    changeElement = true;
                    continue;
                }

                FindCoordinatesOfElement(first, out int y1, out int x1);
                FindCoordinatesOfElement(second, out int y2, out int x2);
                int step;
                int cx1, cy1, cx2, cy2;
                while (!ShareRaysFrom2Points((y1, x1), (y2, x2), layer, out step, out cx1, out cy1, out cx2, out cy2)) // поки не знайдеться шлях
                {
                    layer++;
                    if (resultBoards.Count <= layer)
                        CreateNewBoard(layer);
                }
                MakeDoublePath((cy1, cx1), (cy2, cx2), layer, pathNumber);
                pathNumber++;
                ClearWaves();
            }
        }
        static private void SetUp()
        {
            resultBoards = new List<Cell[,]>();
            CreateNewBoard(0);
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    tempCMatrix[i, j] = baseCMatrix[i, j];
                }
            }
        }
        static private void CreateNewBoard(int layer)
        {
            resultBoards.Add(new Cell[11, 9]);
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    resultBoards[layer][i, j] = new Cell();
                    resultBoards[layer][i, j].Value = baseBoard[i, j].Value;
                    resultBoards[layer][i, j].StringValue = baseBoard[i, j].StringValue;
                }
            }
        }
        static private int FindFirstElement(out string first) // знаходить перший елемент для трасування
        {
            first = "";
            int maxSum, lastMaxSum = 0, firstNumber = -1;
            //знайдемо найбільшу кількість зв'язків
            for (int i = 0; i < 7; i++)
            {
                maxSum = 0;
                for (int j = 0; j < 7; j++)
                {
                    if (tempCMatrix[i, j] != 0)
                        maxSum += tempCMatrix[i, j];
                }
                if (lastMaxSum < maxSum)
                {
                    lastMaxSum = maxSum;
                    firstNumber = i;
                }
            }
            if (firstNumber == -1)
                return -1;
            first = ConvertNumberToLetter(firstNumber + 1);
            return firstNumber;
        }
        static private string ConvertNumberToLetter(int number)  //конвертує числовий елемент в символьне представлення
        {
            foreach (var item in letterNumberConvertion)
            {
                if (item.Value == number)
                {
                    return item.Key;
                }
            }
            return "";
        }
        static private void FindSecondElement(out string second, int firstNumber) // знаходить другий елемент для трасування
        {
            int secondNumber = -1;
            second = "";

            //знайдемо другий елемент
            for (int j = 0; j < 7; j++)
            {
                if (tempCMatrix[firstNumber, j] != 0)
                {
                    tempCMatrix[firstNumber, j]--;
                    tempCMatrix[j, firstNumber]--;
                    secondNumber = j;
                    break;
                }
            }
            second = ConvertNumberToLetter(secondNumber + 1);
        }
        static private void FindCoordinatesOfElement(string element, out int y, out int x) // знахоть координати елемента
        {
            y = 0;
            x = 0;
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (baseBoard[i, j].StringValue == element)
                    {
                        y = i;
                        x = j;
                        i = 11;
                        break;
                    }
                }
            }
        }
        static private bool ShareRaysFrom2Points((int y, int x) firstEl, (int y, int x) secondEl, int layer, out int step, out int x1, out int y1, out int x2, out int y2)
        {
            step = 0;
            x1 = -1; y1 = -1; x2 = -1; y2 = -1;
            bool isFind = false, deadEnd = false;
            Ray[] rays = new Ray[4] { new Ray(), new Ray(), new Ray(), new Ray() };
            rays[0].coordX = firstEl.x; rays[0].coordY = firstEl.y;
            rays[1].coordX = firstEl.x; rays[1].coordY = firstEl.y;
            rays[2].coordX = secondEl.x; rays[2].coordY = secondEl.y;
            rays[3].coordX = secondEl.x; rays[3].coordY = secondEl.y;
            if (firstEl.x - secondEl.x > 0)
            {
                rays[0].Main = Direction.Left;
                rays[1].Add = Direction.Left;
                rays[2].Main = Direction.Right;
                rays[3].Add = Direction.Right;
            }
            else
            {
                rays[0].Main = Direction.Right;
                rays[1].Add = Direction.Right;
                rays[2].Main = Direction.Left;
                rays[3].Add = Direction.Left;
            }
            if (firstEl.y - secondEl.y > 0)
            {
                rays[1].Main = Direction.Up;
                rays[0].Add = Direction.Up;
                rays[3].Main = Direction.Down;
                rays[2].Add = Direction.Down;
            }
            else
            {
                rays[1].Main = Direction.Down;
                rays[0].Add = Direction.Down;
                rays[3].Main = Direction.Up;
                rays[2].Add = Direction.Up;
            }

            int waveNumber, count;
            bool isFirstIteration = true;
            while (!isFind && !deadEnd)
            {
                waveNumber = 1;
                count = 0;
                deadEnd = true;
                foreach (var ray in rays)
                {
                    count++;
                    if (!ray.canTrace)
                        continue;
                    if (!isFirstIteration)
                    {
                        int currentWaveNumber = resultBoards[layer][ray.coordY, ray.coordX].WaveNumber;
                        if (ray.coordY != 10 && resultBoards[layer][ray.coordY + 1, ray.coordX].WaveNumber == -currentWaveNumber && (ray.Main == Direction.Down || ray.Add == Direction.Down))
                        {
                            y2 = ray.coordY + 1;
                            isFind = true;
                        }
                        else if (ray.coordY != 0 && resultBoards[layer][ray.coordY - 1, ray.coordX].WaveNumber == -currentWaveNumber && (ray.Main == Direction.Up || ray.Add == Direction.Up))
                        {
                            y2 = ray.coordY - 1;
                            isFind = true;
                        }
                        else if (ray.coordX != 8 && resultBoards[layer][ray.coordY, ray.coordX + 1].WaveNumber == -currentWaveNumber && (ray.Main == Direction.Right || ray.Add == Direction.Right))
                        {
                            x2 = ray.coordX + 1;
                            isFind = true;
                        }
                        else if (ray.coordX != 0 && resultBoards[layer][ray.coordY, ray.coordX - 1].WaveNumber == -currentWaveNumber && (ray.Main == Direction.Left || ray.Add == Direction.Left))
                        {
                            x2 = ray.coordX - 1;
                            isFind = true;
                        }
                        if (isFind)
                        {
                            if (x2 == -1)
                                x2 = ray.coordX;
                            if (y2 == -1)
                                y2 = ray.coordY;
                            y1 = ray.coordY;
                            x1 = ray.coordX;
                            break;
                        }
                    }

                    if (count > 2)
                        waveNumber = -1;
                    if (Share2RayDirections(layer, step + 1, ray.coordY, ray.coordX, waveNumber, ray, isFirstIteration))
                    {
                        deadEnd = false;
                    }
                    else if (isFirstIteration)
                    {
                        ray.canTrace = false;
                    }


                }
                isFirstIteration = false;
                step++;
            }


            if (isFind)
                return true;

            return false;
        }
        static private bool Share2RayDirections(int layer, int nextStep, int y, int x, int WaveNumber, Ray ray, bool isFirst) // поширює хвилю в 4 напрямках
        {
            Direction current = ray.Main;
            for (int i = 0; i < 2; i++)
            {
                if (isFirst)
                    i = 1;
                if (y != 0 && resultBoards[layer][y - 1, x].Value == 0 && current == Direction.Up)
                {
                    resultBoards[layer][y - 1, x].Value = nextStep;
                    resultBoards[layer][y - 1, x].WaveNumber = WaveNumber;
                    ray.coordY--;
                    return true;
                }
                if (x != 8 && resultBoards[layer][y, x + 1].Value == 0 && current == Direction.Right)
                {
                    resultBoards[layer][y, x + 1].Value = nextStep;
                    resultBoards[layer][y, x + 1].WaveNumber = WaveNumber;
                    ray.coordX++;
                    return true;
                }
                if (y != 10 && resultBoards[layer][y + 1, x].Value == 0 && current == Direction.Down)
                {
                    resultBoards[layer][y + 1, x].Value = nextStep;
                    resultBoards[layer][y + 1, x].WaveNumber = WaveNumber;
                    ray.coordY++;
                    return true;
                }
                if (x != 0 && resultBoards[layer][y, x - 1].Value == 0 && current == Direction.Left)
                {
                    resultBoards[layer][y, x - 1].Value = nextStep;
                    resultBoards[layer][y, x - 1].WaveNumber = WaveNumber;
                    ray.coordX--;
                    return true;
                }
                current = ray.Add;
            }

            return false;
        }
        static private bool ShareWave((int y, int x) firstEl, (int y, int x) secondEl, int layer, out int step) //поширює просту хвилю
        {
            step = 1;
            bool isFind = false, deadEnd = false;
            if (!Share4Directions(layer, step, firstEl.y, firstEl.x, 1))
            {
                return false;
            }
            while (!isFind && !deadEnd)
            {
                deadEnd = true;
                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (resultBoards[layer][i, j].Value == step)
                        {
                            deadEnd = false;
                            if (i + 1 == secondEl.y && j == secondEl.x || i - 1 == secondEl.y && j == secondEl.x || i == secondEl.y && j + 1 == secondEl.x || i == secondEl.y && j - 1 == secondEl.x)
                            {
                                isFind = true;
                                i = 11;
                                break;
                            }
                            Share4Directions(layer, step + 1, i, j, 1);
                        }
                    }
                }
                step++;
            }
            if (isFind)
                return true;

            return false;
        }
        static private bool Share4Directions(int layer, int nextStep, int y, int x, int WaveNumber) // поширює хвилю в 4 напрямках
        {
            bool isSuccess = false;
            if (y != 0 && resultBoards[layer][y - 1, x].Value == 0)
            {
                resultBoards[layer][y - 1, x].Value = nextStep;
                resultBoards[layer][y - 1, x].WaveNumber = WaveNumber;
                isSuccess = true;
            }
            if (x != 8 && resultBoards[layer][y, x + 1].Value == 0)
            {
                resultBoards[layer][y, x + 1].Value = nextStep;
                resultBoards[layer][y, x + 1].WaveNumber = WaveNumber;
                isSuccess = true;
            }
            if (y != 10 && resultBoards[layer][y + 1, x].Value == 0)
            {
                resultBoards[layer][y + 1, x].Value = nextStep;
                resultBoards[layer][y + 1, x].WaveNumber = WaveNumber;
                isSuccess = true;
            }
            if (x != 0 && resultBoards[layer][y, x - 1].Value == 0)
            {
                resultBoards[layer][y, x - 1].Value = nextStep;
                resultBoards[layer][y, x - 1].WaveNumber = WaveNumber;
                isSuccess = true;
            }
            return isSuccess;
        }
        static private void MakeDoublePath((int y, int x) firstStartPoint, (int y, int x) secondStartPoint, int layer, int pathNumber)
        {
            int y1 = secondStartPoint.y, x1 = secondStartPoint.x, y2 = firstStartPoint.y, x2 = firstStartPoint.x;
            Direction lastDirection1 = Direction.Left, lastDirection2 = Direction.Right;
            int waveNumber1 = resultBoards[layer][y1, x1].WaveNumber, waveNumber2 = resultBoards[layer][y2, x2].WaveNumber;
            int stepNumber1 = resultBoards[layer][y1, x1].Value, stepNumber2 = resultBoards[layer][y2, x2].Value;
            CreatePathNumber(layer, y1, x1, pathNumber);
            CreatePathNumber(layer, y2, x2, pathNumber);
            while (stepNumber1 != 0 || stepNumber2 != 0)
            {
                if (stepNumber1 != 0)
                {
                    lastDirection1 = Make1Step(layer, stepNumber1, pathNumber, ref y1, ref x1, lastDirection1, waveNumber1);
                    stepNumber1--;
                }
                if (stepNumber2 != 0)
                {
                    lastDirection2 = Make1Step(layer, stepNumber2, pathNumber, ref y2, ref x2, lastDirection2, waveNumber2);
                    stepNumber2--;
                }
            }
        }
        static private void MakeSimplePath((int y, int x) firstEl, (int y, int x) secondEl, int layer, int step, int pathNumber)
        {
            int y = secondEl.y, x = secondEl.x;
            Direction lastDirection = Direction.Left;
            while (step != 0)
            {
                lastDirection = Make1Step(layer, step, pathNumber, ref y, ref x, lastDirection, 1);
                step--;
            }
        }
        static private Direction Make1Step(int layer, int step, int pathNumber, ref int y, ref int x, Direction lastDirection, int waveNumber)
        {
            Direction currentDirection;
            List<Direction> posibleDirections = new List<Direction>();
            if (y != 0 && resultBoards[layer][y - 1, x].Value == step && resultBoards[layer][y - 1, x].WaveNumber == waveNumber)
                posibleDirections.Add(Direction.Up);
            if (x != 8 && resultBoards[layer][y, x + 1].Value == step && resultBoards[layer][y, x + 1].WaveNumber == waveNumber)
                posibleDirections.Add(Direction.Right);
            if (y != 10 && resultBoards[layer][y + 1, x].Value == step && resultBoards[layer][y + 1, x].WaveNumber == waveNumber)
                posibleDirections.Add(Direction.Down);
            if (x != 0 && resultBoards[layer][y, x - 1].Value == step && resultBoards[layer][y, x - 1].WaveNumber == waveNumber)
                posibleDirections.Add(Direction.Left);

            if (posibleDirections.Count == 0)
                return lastDirection;
            if (posibleDirections.Contains(lastDirection))
            {
                currentDirection = lastDirection;
            }
            else
            {
                currentDirection = posibleDirections[0];
                lastDirection = currentDirection;
            }
            switch (currentDirection)
            {
                case Direction.Left:
                    x--;
                    break;
                case Direction.Up:
                    y--;
                    break;
                case Direction.Right:
                    x++;
                    break;
                case Direction.Down:
                    y++;
                    break;
                default:
                    break;
            }
            CreatePathNumber(layer, y, x, pathNumber);
            return currentDirection;
        }
        static private void CreatePathNumber(int layer, int y, int x, int pathNumber)
        {
            resultBoards[layer][y, x].StringValue = pathNumber.ToString();
            resultBoards[layer][y, x].Value = int.MaxValue;
        }
        static private void ClearWaves()
        {
            foreach (var item in resultBoards)
            {
                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        item[i, j].WaveNumber = 0;
                        if (item[i, j].Value != int.MaxValue)
                            item[i, j].Value = 0;
                    }
                }
            }
        }
        static void ShowResult(List<Cell[,]> matrix, string name, string time)
        {
            Console.WriteLine(name);
            Console.WriteLine("Час: " + time);
            Console.WriteLine("Довжина провідників: " + CalculateLength(matrix) + "\n");
            for (int k = 0; k < matrix.Count; k++)
            {
                Console.WriteLine("Шар " + (k + 1) + "\n");
                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (letters.Contains(matrix[k][i, j].StringValue))
                        {
                            Console.Write(matrix[k][i, j].StringValue + " ");
                        }
                        else
                        {
                            if (matrix[k][i, j].StringValue != null)
                            {
                                Console.Write(matrix[k][i, j].StringValue + " ");
                            }
                            else
                                Console.Write("-" + " ");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
           
        }
        static int CalculateLength(List<Cell[,]> matrix)
        {
            int allCount = 0;
            foreach (var item in matrix)
            {
                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (!letters.Contains(item[i, j].StringValue) && item[i, j].StringValue != null)
                            allCount++;
                    }
                }
            }
            return allCount;
        }

    }
}

WORK#4/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sapr_4
{
    internal class CarnoElement
    {
        public int Coord { get; set; }
        public int Value { get; set; }
        public bool IsUsed { get; set; }
        public CarnoElement()
        {
            IsUsed = false;
        }
    }
    internal class Program
    {
        static int[,] dataMatrix = new int[16, 5];
        static CarnoElement[,] carnoMap = new CarnoElement[4, 4];
        static List<List<CarnoElement>> DZNFgroups, DKNFgroups;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            for (int i = 0; i < 16; i++)
            {
                int mask = i;
                for (int j = 3; j >= 0; j--)
                {
                    if ((mask & 1) == 1)
                        dataMatrix[i, j] = 1;
                    else
                        dataMatrix[i, j] = 0;
                    mask = mask >> 1;
                }
                dataMatrix[i, 4] = 0;
            }

            EnterData();
            ShowMatrix("X1 X2 X3 X4 Y", dataMatrix);
            Calculate();

            Console.ReadLine();
        }
        static void EnterData()
        {
            string data;
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine($"Введіть Y" + (i + 1) + ":");
                data = Console.ReadLine();

                if (int.TryParse(data, out int y) && (y == 1 || y == 0))
                {
                    dataMatrix[i, 4] = y;
                }
                else
                    i--;
                Console.Clear();
            }
        }
        static void ShowMatrix(string text, int[,] matrix)
        {
            Console.WriteLine(text);

            for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
        static void Calculate()
        {
            DZNFgroups = new List<List<CarnoElement>>();
            DKNFgroups = new List<List<CarnoElement>>();
            Console.WriteLine("ДЗНФ: " + CalculateDNFString(1, "*", "+"));
            Console.WriteLine("ДКНФ: " + CalculateDNFString(0, "+", "*"));

            int[] positionsOrder = new int[] { 0, 1, 3, 2 };
            Console.WriteLine("Карта Карно: ");
            Console.WriteLine("   00 01 11 10");
            string[] order = new string[] { "00", "01", "11", "10" };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    carnoMap[positionsOrder[i], positionsOrder[j]] = new CarnoElement() { Coord = i * 4 + j, Value = dataMatrix[i * 4 + j, 4] };                   
                }
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write(order[i] + " ");
                for (int j = 0; j < 4; j++)
                {                  
                    Console.Write(carnoMap[i, j].Value + "  ");
                }
                Console.WriteLine();
            }
            MinimizeDNF(DZNFgroups, 1);
            Console.WriteLine();
            Console.WriteLine("Мінімізована ДЗНФ:\n" + DNFToString(DZNFgroups, 1, "*", "+"));
            MinimizeDNF(DKNFgroups, 0);
            Console.WriteLine("Мінімізована ДКНФ:\n" + DNFToString(DKNFgroups, 0, "+", "*"));

        }
        static string CalculateDNFString(int trueNumber, string innerSign, string outerSign)
        {
            int newLineCounter = 0;
            string str = "";
            for (int i = 0; i < 16; i++)
            {
                if (dataMatrix[i, 4] == trueNumber)
                {
                    str += outerSign + "(";
                    for (int j = 0; j < 4; j++)
                    {
                        if (dataMatrix[i, j] == trueNumber)
                            str += "x" + (j + 1);
                        else
                            str += "!x" + (j + 1);
                        if (j != 3)
                            str += innerSign;
                    }
                    str += ")";
                    newLineCounter++;
                    if (newLineCounter == 3)
                    {
                        newLineCounter = 0;
                        str += Environment.NewLine;
                    }
                }
            }
            str = str.Substring(1, str.Length - 1);
            return str;
        }
        static string DNFToString(List<List<CarnoElement>> groups, int trueNumber, string innerSign, string outerSign)
        {
            string str = "";
            foreach (var group in groups)
            {
                str += outerSign + "(";
                int[,] bits = new int[group.Count, 4];
                bool[] coords = new bool[4] { true, true, true, true };
                int counter = 0;
                foreach (var element in group)
                {
                    int value = element.Coord;
                    for (int i = 3; i >= 0; i--)
                    {
                        bits[counter, i] = value & 1;
                        value = value >> 1;
                    }
                    counter++;
                }

                for (int i = 0; i < 4; i++)
                {
                    if (bits.Length != 1)
                    {
                        for (int j = 1; j < group.Count; j++)
                        {
                            if (bits[j, i] != bits[j - 1, i])
                            {
                                coords[i] = false;
                                break;
                            }
                        }
                    }
                    if (coords[i])
                    {
                        if (bits[0, i] == trueNumber)
                            str += "x" + (i + 1);
                        else
                            str += "!x" + (i + 1);
                        str += innerSign;
                    }
                }
                str = str.Substring(0, str.Length - 1);
                str += ")";
                str += Environment.NewLine;
            }
            str = str.Substring(1, str.Length - 1);
            return str;
        }
        static void MinimizeDNF(List<List<CarnoElement>> groups, int trueNumber)
        {
            bool isEnd = false;
            while (!isEnd)
            {
                isEnd = true;
                int coordY = -1, coordX = -1;
                //перевірка чи вже кінець
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (carnoMap[i, j].Value == trueNumber && !carnoMap[i, j].IsUsed)
                        {
                            if (coordX == -1)
                            {
                                coordX = j;
                                coordY = i;
                            }
                            isEnd = false;
                            if (CheckIfRowOrCol(j, i, trueNumber))
                            {
                                coordY = i;
                                coordX = j;
                                i = 3;
                                break;
                            }
                        }
                    }
                }
                //додати нову групу
                if (coordX != -1)
                {
                    groups.Add(GroupElements(coordY, coordX, trueNumber));
                    foreach (var item in groups[groups.Count - 1])
                        item.IsUsed = true;
                }
            }
        }
        static bool CheckIfRowOrCol(int x, int y, int trueNumber)
        {
            bool resultFirst = true, resultSecond = true;
            for (int i = 0; i < 4; i++)
            {
                if (carnoMap[y, i].Value != trueNumber)
                {
                    resultFirst = false;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (carnoMap[i, x].Value != trueNumber)
                {
                    resultSecond = false;
                }
            }
            if (resultFirst || resultSecond)
                return true;
            else
                return false;

        }
        static List<CarnoElement> GroupElements(int coordY, int coordX, int trueNumber)
        {
            List<CarnoElement> group = new List<CarnoElement>();

            if (!CheckGroup8(group, coordY, coordX, trueNumber))
            {
                if (!CheckGroup4(group, coordY, coordX, trueNumber))
                {
                    if (!CheckGroup2(group, coordY, coordX, trueNumber))
                    {
                        group.Add(carnoMap[coordY, coordX]);
                    }
                }
            }

            return group;
        }
        static bool CheckGroup8(List<CarnoElement> group, int coordY, int coordX, int trueNumber)
        {
            int i;
            int[] positions;
            bool isRow;

            //перевірка рядків і стовпців по 2
            for (int q = 0; q < 2; q++)
            {
                if (q == 0)
                {
                    positions = new int[3] { coordY, coordY + 1, coordY - 1 };
                    isRow = true;
                }
                else
                {
                    positions = new int[3] { coordX, coordX + 1, coordX - 1 };
                    isRow = false;
                }
                if (positions[1] > 3)
                    positions[1] = 0;
                if (positions[2] < 0)
                    positions[2] = 3;

                for (int k = 0; k < 3; k++)
                {
                    i = positions[k];
                    if (CheckRowOrCol(i, isRow, trueNumber))
                    {
                        AddRowOrCol(group, i, isRow);
                        if (group.Count == 8)
                            return true;
                    }
                    else if (k == 0)
                    {
                        if (group.Count == 0)
                            break;
                    }
                }
                group.Clear();
            }
            return false;
        }
        static bool CheckGroup4(List<CarnoElement> group, int coordY, int coordX, int trueNumber)
        {
            int i;
            bool isRow;

            //перевірка квадратів
            for (int k = 1; k >= -1; k -= 2)
            {
                for (int j = 1; j >= -1; j -= 2)
                {
                    int offsetY = CheckOffset(coordY, k);
                    int offsetX = CheckOffset(coordX, j);
                    if (CheckSquare(coordY, coordX, offsetY, offsetX, trueNumber))
                    {
                        AddSquare(group, coordY, coordX, offsetY, offsetX);
                        return true;
                    }
                }
            }

            //перевірка рядків і стовпців
            for (int q = 0; q < 2; q++)
            {
                if (q == 0)
                {
                    isRow = true;
                    i = coordY;
                }
                else
                {
                    isRow = false;
                    i = coordX;
                }
                if (CheckRowOrCol(i, isRow, trueNumber))
                {
                    AddRowOrCol(group, i, isRow);
                    return true;
                }
            }
            return false;
        }
        static bool CheckGroup2(List<CarnoElement> group, int coordY, int coordX, int trueNumber)
        {
            group.Add(carnoMap[coordY, coordX]);

            int offsetY = CheckOffset(coordY, -1);
            for (int i = 0; i < 2; i++)
            {
                if (carnoMap[coordY + offsetY, coordX].Value == trueNumber)
                {
                    group.Add(carnoMap[coordY + offsetY, coordX]);
                    return true;
                }
                offsetY = CheckOffset(coordY, 1);
            }

            int offsetX = CheckOffset(coordX, 1);
            for (int i = 0; i < 2; i++)
            {
                if (carnoMap[coordY, coordX + offsetX].Value == trueNumber)
                {
                    group.Add(carnoMap[coordY, coordX + offsetX]);
                    return true;
                }
                offsetX = CheckOffset(coordX, -1);
            }

            group.Clear();
            return false;
        }
        static int CheckOffset(int coord, int offset)
        {
            if (offset > 0 && coord + offset == 4)
                return offset - 4;
            if (offset < 0 && coord + offset == -1)
                return offset + 4;
            return offset;
        }
        static bool CheckSquare(int i, int j, int offsetI, int offsetJ, int trueNumber)
        {
            if (carnoMap[i, j + offsetJ].Value != trueNumber || carnoMap[i + offsetI, j].Value != trueNumber || carnoMap[i + offsetI, j + offsetJ].Value != trueNumber)
            {
                return false;
            }
            return true;
        }
        static void AddSquare(List<CarnoElement> group, int i, int j, int offsetI, int offsetJ)
        {
            group.Add(carnoMap[i, j]);
            group.Add(carnoMap[i + offsetI, j]);
            group.Add(carnoMap[i, j + offsetJ]);
            group.Add(carnoMap[i + offsetI, j + offsetJ]);
        }
        static bool CheckRowOrCol(int i, bool isRow, int trueNumber)
        {
            if (isRow)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (carnoMap[i, j].Value != trueNumber)
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int j = 0; j < 4; j++)
                {
                    if (carnoMap[j, i].Value != trueNumber)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void AddRowOrCol(List<CarnoElement> group, int index, bool isRow)
        {
            if (isRow)
            {
                for (int j = 0; j < 4; j++)
                {
                    group.Add(carnoMap[index, j]);
                }
            }
            else
            {
                for (int j = 0; j < 4; j++)
                {
                    group.Add(carnoMap[j, index]);
                }
            }
        }
    }
}

