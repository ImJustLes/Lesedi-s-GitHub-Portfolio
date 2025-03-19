package com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.service;

import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.model.DisposalGuideline;

import java.util.List;
import java.util.Optional;

//Mainly from creating new Service Classes
public abstract class Service<T> {

    public abstract List<T> getAll();

    public abstract Optional<T> getByID(Long id);

    public abstract void deleteByID(Long id);

    public abstract T update(Long id, T data);

    public abstract T save(T data);
}
