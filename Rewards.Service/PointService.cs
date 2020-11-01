using Rewards.Core.Entities;
using Rewards.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rewards.Service
{
    public class PointService : IPointService
    {
        private readonly IPointRepository _pointRepository;
        private readonly IUserRepository _userRepository;

        public PointService(IPointRepository pointRepository, IUserRepository userRepository)
        {
            _pointRepository = pointRepository;
            _userRepository = userRepository;
        }

        public void UpdatePoints(int userId, int points)
        {
            var user = _userRepository.Get(userId);

            if (user == null)
                throw new Exception("Usuário não encontrado");


            var pointObj = new Points(userId, points);

            _pointRepository.Update(pointObj);
        }
    }
}
