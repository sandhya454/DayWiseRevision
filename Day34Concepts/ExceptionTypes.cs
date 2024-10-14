using System;

namespace Day34Concepts.ExceptionTypes
{
    public class ExceptionTypesExamples
    {
        public void BasicExample()
        {
            try
            {
                Console.WriteLine(Arithematic(10, 10));
            }
            catch (NumDenoEqualException ex)
            {
                Console.WriteLine(1);

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by zero not possible corrected to 1");
                Console.WriteLine(Arithematic(10, 1));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thankyou");
            }
        }

        public int Arithematic(int firstNumber, int secondNumber)
        {
            int result = Divide(firstNumber, secondNumber);
            return result;
        }
        public int Divide(int firstNumber, int secondNumber)
        {
            if (firstNumber < 0 || secondNumber < 0)
            {
                throw new Exception("Negative numbers are not allowed");
            }
            if (firstNumber == secondNumber)
            {
                throw new NumDenoEqualException("Numerator and denominator are same");
            }
            int result = firstNumber / secondNumber;
            return result;
        }

        public class NumDenoEqualException : Exception
        {
            public NumDenoEqualException(string message) : base(message)
            {
            }
        }

        public void PrintLength(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Input string cannot be null.");
            }
            Console.WriteLine($"Length of string: {input.Length}");
        }

        public void ProcessString()
        {
            try
            {
                PrintLength(null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("String processing completed.");
            }
        }
    }

    public class InvalidEmailException : Exception
    {
        public InvalidEmailException(string message) : base(message)
        {
        }
    }

    public class EmailValidator
    {
        public void ValidateEmail(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
            {
                throw new InvalidEmailException($"Email '{email}' is invalid. Please provide a valid email address.");
            }
            Console.WriteLine($"Email '{email}' is valid.");
        }

        public void ProcessEmail()
        {
            try
            {
                ValidateEmail("invalid-email");
            }
            catch (InvalidEmailException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Email validation completed.");
            }
        }
    }

    public class LibrarySystem
    {
        private bool isBookAvailable = false;
        private int booksIssued = 5;
        private bool isMembershipValid = false;
        private const int MaxBooksAllowed = 5;

        public void LendBook(string bookTitle)
        {
            if (!isMembershipValid)
            {
                throw new InvalidMembershipException("Membership is invalid or expired.");
            }

            if (!isBookAvailable)
            {
                throw new BookNotAvailableException($"The book '{bookTitle}' is currently not available.");
            }

            if (booksIssued >= MaxBooksAllowed)
            {
                throw new MaxBooksIssuedException("You have already issued the maximum number of books.");
            }

            // Code to lend the book to the user
            booksIssued++;
            Console.WriteLine($"The book '{bookTitle}' has been successfully lent.");
        }

        public void ProcessLending(string bookTitle)
        {
            try
            {
                LendBook(bookTitle);
            }
            catch (InvalidMembershipException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (BookNotAvailableException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (MaxBooksIssuedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Lending process completed.");
            }
        }
    }

    public class BookNotAvailableException : Exception
    {
        public BookNotAvailableException(string message) : base(message)
        {
        }
    }

    public class MaxBooksIssuedException : Exception
    {
        public MaxBooksIssuedException(string message) : base(message)
        {
        }
    }

    public class InvalidMembershipException : Exception
    {
        public InvalidMembershipException(string message) : base(message)
        {
        }
    }
}
