
using MongoDB.Driver;

public class UserService : IUserService
{
    private readonly IMongoCollection<User> _users;

    public UserService(IUserStoreDatabaseSettings settings, IMongoClient mongoClient)
    {
        var database = mongoClient.GetDatabase(settings.DatabaseName);
        _users = database.GetCollection<User>(settings.UsersCollectionName);
    }

    public User Create(User user)
    {
        _users.InsertOne(user);
        return user;
    }

    public List<User> Get()
    {
        return _users.Find(student => true).ToList();
    }

    public User Get(string id)
    {
        return _users.Find(student => student.Id == id).FirstOrDefault();
    }

    public void Remove(string id)
    {
        _users.DeleteOne(student => student.Id == id);
    }

    public void Update(string id, User student)
    {
        _users.ReplaceOne(student => student.Id == id, student);
    }
}
