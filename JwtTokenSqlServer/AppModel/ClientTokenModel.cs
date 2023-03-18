namespace JwtTokenSqlServer.AppModel
{
    public class ClientTokenModel
    {
        public string ClientId { get; set; }
        public string Secret { get; set; }
        public string UserMessage { get; set; }
        public string AccessToken { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
