using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity.Validation;
using System.Windows;
using GamingPlatform.UserControlMainWindow;
namespace GamingPlatform.AllLogic
{


    interface IRepository<T> : IDisposable
    {
        List<T> GetAll();
        T GetById(int id);
        void Create(T item);
        void Save();
    }

    interface IRepositoryGames<T> : IDisposable
    {
        List<T> GetAll();
        T GetById(int id);
        void Create(T item);
        void Save();
        Player GetPlayer();
        void WriteResult(int score);
    }


    public class UsersRepository : IRepository<Player>
    {
        private static UsersRepository usersRepository = null;
        public GamingPlatformDB_v4Entities db = null;

        public UsersRepository()
        {
            this.db = new GamingPlatformDB_v4Entities();
        }
        public static UsersRepository Initialize()
        {
            if (usersRepository == null)
                usersRepository = new UsersRepository();
            return usersRepository;
        }

        public List<Player> GetAll()
        {
            return db.Players.ToList();
        }
        public void Create(Player item)
        {
            db.Players.Add(item);
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public Player GetById(int id)
        {
            return GetAll().Find(item => item.IDPlayer == id);
        }
        public void Save()
        {
            db.SaveChanges();
        }

        public Player GetByLogin(string login)
        {
            return GetAll().Find(item => item.LoginUser == login);
        }

        public void Sign(string login, string password)
        {

            Player result = GetByLogin(login);
            if (result == null)
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            else if (HashPassword.Verify(result.SaltUser, result.HashUser, password))
            {
                ActiveUser.UserId = result.IDPlayer;
                ActiveUser.UserLogin = result.LoginUser;
                ActiveUser.UserName = result.NameUser;
                ActiveUser.UserPassword = password;
                ActiveUser.DateRegistr = result.RegistrDate;
                InitializeWindows.mm = new MainMenu();
                InitializeWindows.mm.DataContext = new StartMainMenu();
                InitializeWindows.mm.playerName.Content = ActiveUser.UserName;
                InitializeWindows.mm.Show();
                InitializeWindows.mw.Close();
                InitializeWindows.mw = new MainWindow();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }


        public void Registration()
        {
            Player result = GetByLogin(ActiveUser.UserLogin);
            if (result != null)
            {
                MessageBox.Show("Аккаунт с таким логином уже существует");
            }
            else
            {
                Player newUser = new Player();
                newUser.LoginUser = ActiveUser.UserLogin;
                newUser.NameUser = ActiveUser.UserName;
                newUser.RegistrDate = ActiveUser.DateRegistr;
                HashPassword hp = new HashPassword(ActiveUser.UserPassword);
                newUser.HashUser = hp.Hash;
                newUser.SaltUser = hp.Salt;
                Create(newUser);
                Save();
                MessageBox.Show("Аккаунт успешно создан");

                //catch (DbEntityValidationException ex)
                //{
                //    string message = "";
                //    foreach (DbEntityValidationResult validationError in ex.EntityValidationErrors)
                //    {
                //        message = "Object: " + validationError.Entry.Entity.ToString();

                //        foreach (DbValidationError err in validationError.ValidationErrors)
                //        {
                //            message = message + err.ErrorMessage + "";
                //        }
                //    }
                //    MessageBox.Show(message);
                //}

            }
        }


        public void ChangePassword(string password)
        {
            Player result = GetByLogin(ActiveUser.UserLogin);
            HashPassword hp = new HashPassword(password);
            result.HashUser = hp.Hash;
            result.SaltUser = hp.Salt;
            ActiveUser.UserPassword = password;
            Save();
            MessageBox.Show("Вы поменяли пароль");

        }


    }

    public class SnakeRepositoty : IRepositoryGames<SnakeGame>
    {
        private static SnakeRepositoty snakeRepositoty = null;
        public GamingPlatformDB_v4Entities db = null;

        public SnakeRepositoty()
        {
            this.db = new GamingPlatformDB_v4Entities();
        }
        public static SnakeRepositoty Initialize()
        {
            if (snakeRepositoty == null)
                snakeRepositoty = new SnakeRepositoty();
            return snakeRepositoty;
        }
        public void Create(SnakeGame item)
        {
            db.SnakeGames.Add(item);
        }
        public void Dispose()
        {
            db.Dispose();
        }
        public List<SnakeGame> GetAll()
        {
            return db.SnakeGames.ToList();
        }

        public SnakeGame GetById(int id)
        {
            return GetAll().Find(item => item.ID == id);
        }

        public Player GetPlayer()
        {
            return db.Players.ToList().Find(item => item.IDPlayer == ActiveUser.UserId);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void WriteResult(int score)
        {
            Player player = GetPlayer();
            SnakeGame game = GetAll().Find(item => item.Player == player);
            if (game == null)
            {
                SnakeGame addUser = new SnakeGame();
                addUser.Player = player;
                addUser.BestScore = score;
                Create(addUser);
            }
            else if (score > game.BestScore)
            {
                game.BestScore = score;
            }
            Save();
        }
    }

    public class MemoryCardsRepository : IRepositoryGames<MemoryCardsGame>
    {
        private static MemoryCardsRepository memoryCardsRepository = null;
        public GamingPlatformDB_v4Entities db = null;

        public MemoryCardsRepository()
        {
            this.db = new GamingPlatformDB_v4Entities();
        }
        public static MemoryCardsRepository Initialize()
        {
            if (memoryCardsRepository == null)
                memoryCardsRepository = new MemoryCardsRepository();
            return memoryCardsRepository;
        }
        public void Create(MemoryCardsGame item)
        {
            db.MemoryCardsGames.Add(item);
        }
        public void Dispose()
        {
            db.Dispose();
        }
        public List<MemoryCardsGame> GetAll()
        {
            return db.MemoryCardsGames.ToList();
        }

        public MemoryCardsGame GetById(int id)
        {
            return GetAll().Find(item => item.ID == id);
        }

        public Player GetPlayer()
        {
            return db.Players.ToList().Find(item => item.IDPlayer == ActiveUser.UserId);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void WriteResult(int score)
        {
            Player player = GetPlayer();
            MemoryCardsGame game = GetAll().Find(item => item.Player == player);
            if (game == null)
            {
                MemoryCardsGame addUser = new MemoryCardsGame();
                addUser.Player = player;
                addUser.BestScore = score;
                Create(addUser);
            }
            else if (score > game.BestScore)
            {
                game.BestScore = score;
            }
            Save();
        }
    }

    public class BallRepository : IRepositoryGames<GameBall>
    {
        private static BallRepository repository = null;
        public GamingPlatformDB_v4Entities db = null;

        public BallRepository()
        {
            this.db = new GamingPlatformDB_v4Entities();
        }
        public static BallRepository Initialize()
        {
            if (repository == null)
                repository = new BallRepository();
            return repository;
        }
        public void Create(GameBall item)
        {
            db.GameBalls.Add(item);
        }
        public void Dispose()
        {
            db.Dispose();
        }
        public List<GameBall> GetAll()
        {
            return db.GameBalls.ToList();
        }

        public GameBall GetById(int id)
        {
            return GetAll().Find(item => item.ID == id);
        }

        public Player GetPlayer()
        {
            return db.Players.ToList().Find(item => item.IDPlayer == ActiveUser.UserId);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void WriteResult(int score)
        {
            Player player = GetPlayer();
            GameBall game = GetAll().Find(item => item.Player == player);
            if (game == null)
            {
                GameBall addUser = new GameBall();
                addUser.Player = player;
                addUser.BestScore = score;

                Create(addUser);
            }
            else if (score > game.BestScore)
            {
                game.BestScore = score;
            }
            Save();
        }
    }

    public class SwitchRepository : IRepositoryGames<GameSwitch>
    {
        private static SwitchRepository repository = null;
        public GamingPlatformDB_v4Entities db = null;

        public SwitchRepository()
        {
            this.db = new GamingPlatformDB_v4Entities();
        }
        public static SwitchRepository Initialize()
        {
            if (repository == null)
                repository = new SwitchRepository();
            return repository;
        }
        public void Create(GameSwitch item)
        {
            db.GameSwitches.Add(item);
        }
        public void Dispose()
        {
            db.Dispose();
        }
        public List<GameSwitch> GetAll()
        {
            return db.GameSwitches.ToList();
        }

        public GameSwitch GetById(int id)
        {
            return GetAll().Find(item => item.ID == id);
        }

        public Player GetPlayer()
        {
            return db.Players.ToList().Find(item => item.IDPlayer == ActiveUser.UserId);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void WriteResult(int score)
        {
            Player player = GetPlayer();
            GameSwitch game = GetAll().Find(item => item.Player == player);
            if (game == null)
            {
                GameSwitch addUser = new GameSwitch();
                addUser.Player = player;
                addUser.BestScore = score;

                Create(addUser);
            }
            else if (score < game.BestScore)
            {
                game.BestScore = score;
            }
            Save();
        }
    }

    public class TetrisRepository : IRepositoryGames<GameTetri>
    {
        private static TetrisRepository repository = null;
        public GamingPlatformDB_v4Entities db = null;

        public TetrisRepository()
        {
            this.db = new GamingPlatformDB_v4Entities();
        }
        public static TetrisRepository Initialize()
        {
            if (repository == null)
                repository = new TetrisRepository();
            return repository;
        }
        public void Create(GameTetri item)
        {
            db.GameTetris.Add(item);
        }
        public void Dispose()
        {
            db.Dispose();
        }
        public List<GameTetri> GetAll()
        {
            return db.GameTetris.ToList();
        }

        public GameTetri GetById(int id)
        {
            return GetAll().Find(item => item.ID == id);
        }

        public Player GetPlayer()
        {
            return db.Players.ToList().Find(item => item.IDPlayer == ActiveUser.UserId);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void WriteResult(int score)
        {
            Player player = GetPlayer();
            GameTetri game = GetAll().Find(item => item.Player == player);
            if (game == null)
            {
                GameTetri addUser = new GameTetri();
                addUser.Player = player;
                addUser.BestScore = score;

                Create(addUser);
            }
            else if (score > game.BestScore)
            {
                game.BestScore = score;
            }
            Save();
        }
    }

    public class MineRepository : IRepositoryGames<GameMine>
    {
        private static MineRepository repository = null;
        public GamingPlatformDB_v4Entities db = null;

        public MineRepository()
        {
            this.db = new GamingPlatformDB_v4Entities();
        }
        public static MineRepository Initialize()
        {
            if (repository == null)
                repository = new MineRepository();
            return repository;
        }
        public void Create(GameMine item)
        {
            db.GameMines.Add(item);
        }
        public void Dispose()
        {
            db.Dispose();
        }
        public List<GameMine> GetAll()
        {
            return db.GameMines.ToList();
        }

        public GameMine GetById(int id)
        {
            return GetAll().Find(item => item.ID == id);
        }

        public Player GetPlayer()
        {
            return db.Players.ToList().Find(item => item.IDPlayer == ActiveUser.UserId);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void WriteResult(int score)
        {
            Player player = GetPlayer();
            GameMine game = GetAll().Find(item => item.Player == player);
            if (game == null)
            {
                GameMine addUser = new GameMine();
                addUser.Player = player;
                addUser.BestScore = score;
                Create(addUser);
            }
            else if (score < game.BestScore)
            {
                game.BestScore = score;
            }
            Save();
        }
    }

}
