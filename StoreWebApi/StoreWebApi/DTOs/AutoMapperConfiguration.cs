using AutoMapper;
using StoreWebApi.Models;

namespace StoreWebApi.DTOs
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Usuario, UsuarioDTO>()
                   .ForMember(x => x.Cliente, o => o.Ignore())
                   .ReverseMap();
                cfg.CreateMap<Usuario, UsuarioDTO>()
                   .ForMember(x => x.Encargado, o => o.Ignore())
                   .ReverseMap();

                cfg.CreateMap<Encargado, EncargadoDTO>()
                   .ForMember(x => x.Reservas, o => o.Ignore())
                   .ReverseMap();
                cfg.CreateMap<Encargado, EncargadoDTO>()
                   .ForMember(x => x.Prestamos, o => o.Ignore())
                   .ReverseMap();
                cfg.CreateMap<Encargado, EncargadoDTO>()
                   .ForMember(x => x.Retornos, o => o.Ignore())
                   .ReverseMap();
                
                cfg.CreateMap<Cliente, ClienteDTO>()
                   .ForMember(x => x.Reservas, o => o.Ignore())
                   .ReverseMap();

                cfg.CreateMap<Reserva, ReservaDTO>()
                   .ForMember(x => x.Prestamo, o => o.Ignore())
                   .ReverseMap();

                cfg.CreateMap<Prestamo, PrestamoDTO>()
                   .ForMember(x => x.Retornos, o => o.Ignore())
                   .ReverseMap();

                cfg.CreateMap<Retorno, RetornoDTO>()
                   .ReverseMap();

                cfg.CreateMap<ProductoInventario, ProductoInventarioDTO>()
                   .ForMember(x => x.Reservas, o => o.Ignore())
                   .ReverseMap();

                cfg.CreateMap<Producto, ProductoDTO>()
                   .ForMember(x => x.ProductoInventario, o => o.Ignore())
                   .ReverseMap();

                cfg.CreateMap<Categoria, CategoriaDTO>()
                   .ForMember(x => x.Productos, o => o.Ignore())
                   .ReverseMap();

                cfg.CreateMap<Customer, CustomerDTO>()
                   .ForMember(x => x.CustomerOrder, o => o.Ignore())
                   .ReverseMap();

                cfg.CreateMap<CustomerOrder, CustomerOrderDTO>()
                   .ForMember(x => x.OrderDetail, o => o.Ignore())
                   .ReverseMap();

                cfg.CreateMap<Employee, EmployeeDTO>()
                   .ReverseMap();

                cfg.CreateMap<OrderDetail, OrderDetailDTO>()
                   .ReverseMap();

                cfg.CreateMap<OrderStatus, OrderStatusDTO>()
                   .ForMember(x => x.CustomerOrder, o => o.Ignore())
                   .ReverseMap();

                cfg.CreateMap<Product, ProductoDTO>()
                   .ForMember(x => x.ProductoInventario, o => o.Ignore())
                   .ReverseMap();
            });
        }
    }
}
