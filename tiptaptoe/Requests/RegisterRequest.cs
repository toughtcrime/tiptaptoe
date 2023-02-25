namespace TicTacToe.Requests
{
    public record RegisterRequest(
        string Username,
        string Email, 
        string Password, 
        string RepeatPassword);
}
