package com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.service;

public interface APIService {

    String apiVersion = "v2";
    String apiName = "environment";
    String API_URL = "/" + apiVersion + "/" + apiName;
    String SAVE_URL = "/save";
    String UPDATE_URL = "/update/{id}";
    String DELETE_URL = "/delete/{id}";
}
