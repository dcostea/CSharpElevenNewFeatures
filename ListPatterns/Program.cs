using static System.Console;


var numbers = new[] { 1, 2, 3, 4 };

// List and constant patterns 
WriteLine(numbers is [1, 2, 3, 4]); // True 
WriteLine(numbers is [1, 2, 4]); // False

// List and discard patterns 
WriteLine(numbers is [_, 2, _, 4]); // True 
WriteLine(numbers is [.., 3, _]); // True

// List and logical patterns 
WriteLine(numbers is [_, >= 2, _, _]); // True
