// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
        {
            // key'e sahip olan Scope'taki işlemleri yapabilme yetkisi vardır.
            new ApiResource("ResourceCatalog"){ Scopes = {"CatalogFullPermission","CatalogReadPermission"}},
            new ApiResource("ResourceOrder"){ Scopes = {"OrderFullPermission"}},
            new ApiResource("ResourceCargo"){ Scopes = {"CargoFullPermission"}},

            new ApiResource(IdentityServerConstants.LocalApi.ScopeName)

        };

        public static IEnumerable<IdentityResource> IdentityResources => new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Email(),
            new IdentityResources.Profile(),
        };

        public static IEnumerable<ApiScope> ApiScopes => new ApiScope[]
        {
           new ApiScope("CatalogFullPermission","Full permission for catalog operation."),
           new ApiScope("CatalogReadPermission","Only read permission for catalog operation."),
           new ApiScope("OrderFullPermission","Only read permission for order operation."),
           new ApiScope("CargoFullPermission","Only read permission for cargo operation."),

           new ApiScope(IdentityServerConstants.LocalApi.ScopeName)

        };

        //Kullanıcının sahip olduğu izinler ayarlanır.
        public static IEnumerable<Client> Clients => new Client[]
        {
           //Visitor
           new Client
           {
               ClientId = "BookStoreVisitorId",
               ClientName = "BookStore Visitor User",
               AllowedGrantTypes=GrantTypes.ClientCredentials,
               ClientSecrets = {new Secret("bookstoresecret".Sha256()) },
               AllowedScopes = {"CatalogReadPermission"}
           },

           //Manager
           new Client
           {
               ClientId = "BookStoreManagerId",
               ClientName = "BookStore Manager User",
               AllowedGrantTypes=GrantTypes.ClientCredentials,
               ClientSecrets = {new Secret("bookstoresecret".Sha256()) },
               AllowedScopes = { "CatalogFullPermission","CatalogReadPermission" }
           },

           //Admin
           new Client
           {
               ClientId = "BookStoreAdminId",
               ClientName = "BookStore Adnin User",
               AllowedGrantTypes=GrantTypes.ClientCredentials,
               ClientSecrets = {new Secret("bookstoresecret".Sha256()) },
               AllowedScopes = { "CatalogFullPermission","CatalogReadPermission", "OrderFullPermission", "CargoFullPermission",
               IdentityServerConstants.LocalApi.ScopeName,
               IdentityServerConstants.StandardScopes.Email,
               IdentityServerConstants.StandardScopes.OpenId,
               IdentityServerConstants.StandardScopes.Profile
               },
               AccessTokenLifetime=600
           },

        };

    }
}