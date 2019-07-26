using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicesBase
{
    class Morpion 
    {
        private bool _isPlayerOne;

        private int _numberOfMoves;

        private List<int> _plateau;

        public Morpion() {
            Init();
        }

        public void Game() {

            DisplayGrid();

            while (_numberOfMoves != 9) {
                Console.WriteLine($"C'est au tour du joueur n°{(_isPlayerOne ? 1 : 2)} de jouer");

                int xCord, yCord;

                do {
                    xCord = Utilities.GetUserIntInput("Entrez une valeur en X : ");
                    yCord = Utilities.GetUserIntInput("Entrez une valeur en Y : ");
                } while (!CanPlaceElement(xCord, yCord));

                SetElement(xCord, yCord);

                DisplayGrid();

                if (CheckIfWin()) {
                    Console.WriteLine($"Le joueur {(_isPlayerOne ? "1" : "2")} a gagné !");
                    break;
                }

                _numberOfMoves++;
                _isPlayerOne = !_isPlayerOne;
            }

        }

        private void Init() {
            _plateau = new List<int> {
                0, 0, 0,
                0, 0, 0,
                0, 0, 0
            };

            _isPlayerOne = true;
            _numberOfMoves = 0;
        }

        private int GetGridLocalisation(int x, int y) {
            return 3 * x + y;
        }

        private char GetElementToDisplay(int x, int y) {
            int i = _plateau[GetGridLocalisation(x, y)];

            if (i == 0) return '#';
            if (i == 1) return 'O';
            if (i == 2) return 'X';

            return 'E';
        }

        private bool CanPlaceElement(int x, int y) {
            if (x < 0 || x > 2) return false;
            if (y < 0 || y > 2) return false;
            return _plateau[GetGridLocalisation(x, y)] == 0;
        }

        private void SetElement(int x, int y) {
            _plateau[GetGridLocalisation(x, y)] = _isPlayerOne ? 1 : 2;
        }

        private bool CheckIfWin() {
            if (_numberOfMoves < 3) return false;

            for (int i = 0; i < 3; i++) {
                if (_plateau[GetGridLocalisation(i,0)] != 0 &&
                    _plateau[GetGridLocalisation(i, 0)] == _plateau[GetGridLocalisation(i, 1)] &&
                    _plateau[GetGridLocalisation(i, 1)] == _plateau[GetGridLocalisation(i, 2)])
                    return true;

                if (_plateau[GetGridLocalisation(0,i)] != 0 &&
                    _plateau[GetGridLocalisation(0, i)] == _plateau[GetGridLocalisation(1, i)] &&
                    _plateau[GetGridLocalisation(1, i)] == _plateau[GetGridLocalisation(2, i)])
                    return true;
            }

            if (_plateau[GetGridLocalisation(0, 0)] != 0 &&
                _plateau[GetGridLocalisation(0, 0)] == _plateau[GetGridLocalisation(1, 1)] &&
                _plateau[GetGridLocalisation(1, 1)] == _plateau[GetGridLocalisation(2, 2)])
                return true;

            if (_plateau[GetGridLocalisation(0, 2)] != 0                                   &&
                _plateau[GetGridLocalisation(0, 2)] == _plateau[GetGridLocalisation(1, 1)] &&
                _plateau[GetGridLocalisation(1, 1)] == _plateau[GetGridLocalisation(2, 0)])
                return true;

            return false;
        }

        private void DisplayGrid() {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 3; i++) {
                if(i != 0)
                    stringBuilder.Append('\n');

                stringBuilder.Append('-', 13);
                stringBuilder.Append('\n');

                for (int j = 0; j < 3; j++) {
                    if (j == 0) {
                        stringBuilder.Append('|');
                    }
                    stringBuilder.Append($" {GetElementToDisplay(i, j)} |");
                }

            }
            
            stringBuilder.Append('\n');
            stringBuilder.Append('-', 13);
            Console.WriteLine(stringBuilder);
        }
    }
}
