﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GamingPlatform
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GamingPlatformDB_v4Entities : DbContext
    {
        public GamingPlatformDB_v4Entities()
            : base("name=GamingPlatformDB_v4Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GameBall> GameBalls { get; set; }
        public virtual DbSet<GameMine> GameMines { get; set; }
        public virtual DbSet<GameSwitch> GameSwitches { get; set; }
        public virtual DbSet<GameTetri> GameTetris { get; set; }
        public virtual DbSet<MemoryCardsGame> MemoryCardsGames { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<SnakeGame> SnakeGames { get; set; }
        public virtual DbSet<TicTacMatch> TicTacMatches { get; set; }
    }
}
