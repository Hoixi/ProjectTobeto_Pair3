﻿using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CityRequests;
using Business.Dtos.Requests.UserSocialMediaRequests;
using Business.Dtos.Responses.CityResponses;
using Business.Dtos.Responses.UserSocialMediaResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class UserSocialMediaManager : IUserSocialMediaService
    {
        IUserSocialMediaDal _userSocialMediaDal;
        IMapper _mapper;

        public UserSocialMediaManager(IUserSocialMediaDal userSocialMediaDal, IMapper mapper)
        {
            _userSocialMediaDal = userSocialMediaDal;
            _mapper = mapper;
        }

        public async Task<CreatedUserSocialMediaResponse> Add(CreateUserSocialMediaRequest createUserSociaMediaRequest)
        {
            UserSocialMedia userSocialMedia = _mapper.Map<UserSocialMedia>(createUserSociaMediaRequest);
            UserSocialMedia createdUserSocialMedia = await _userSocialMediaDal.AddAsync(userSocialMedia);
            CreatedUserSocialMediaResponse createdUserSocialMediaResponse = _mapper.Map<CreatedUserSocialMediaResponse>(createdUserSocialMedia);
            return createdUserSocialMediaResponse;
        }

        public async Task<UserSocialMedia> Delete(int id)
        {
            var data = await _userSocialMediaDal.GetAsync(i => i.Id == id);
            var result = await _userSocialMediaDal.DeleteAsync(data);
            return result;
        }

        public async Task<IPaginate<GetListUserSocialMediaResponse>> GetAll(PageRequest pageRequest)
        {
            var data = await _userSocialMediaDal.GetListAsync(
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
               );
            var result = _mapper.Map<Paginate<GetListUserSocialMediaResponse>>(data);
            return result;
        }

        public async Task<UpdatedUserSocialMediaResponse> Update(UpdateUserSocialMediaRequest updateUserSocialMediaRequest)
        {
            var data = await _userSocialMediaDal.GetAsync(i => i.Id == updateUserSocialMediaRequest.Id);
            _mapper.Map(updateUserSocialMediaRequest, data);
            data.UpdatedDate = DateTime.Now;
            await _userSocialMediaDal.UpdateAsync(data);
            var result = _mapper.Map<UpdatedUserSocialMediaResponse>(data);
            return result;
        }
    }
}