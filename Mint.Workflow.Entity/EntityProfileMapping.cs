using AutoMapper;
using Mint.Workflow.Entity.Dtos;
using Mint.Workflow.Entity.Vos;
using Mint.Workflow.Entity.Models;

namespace Mint.Workflow.Entity {
	/// <summary>
	/// 映射配置文件
	/// 用于配置Dto和Model的映射关系
	/// 通过继承AutoMapper.Profile类来实现映射配置
	/// </summary>
	public class EntityProfileMapping : Profile {
		// 配置实体映射关系
		public EntityProfileMapping(){
			
			//单向映射(UserCreateDto -> User)
			CreateMap<UserCreateDto, User>();
			//单向映射(User -> UserCreateDto)
			CreateMap<User, UserCreateDto>();
			//单向映射(User --> UserLoginVo)
			CreateMap<User, UserLoginVo>();
			
		}
	}
}