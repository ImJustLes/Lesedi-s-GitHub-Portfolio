package com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.service;

import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.model.Waste;
import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.repo.WasteRepo;
import org.springframework.beans.factory.annotation.Autowired;

import java.util.List;
import java.util.Optional;

@org.springframework.stereotype.Service
public class WasteService extends Service<Waste>{

    @Autowired
    private WasteRepo wasteRepo;

    public List<Waste> getAll() {
        return wasteRepo.findAll();
    }

    public Optional<Waste> getByID(Long id) {
        return wasteRepo.findById(id);
    }

    public void deleteByID(Long id) {
        wasteRepo.deleteById(id);
    }

    public Waste update(Long id, Waste newWaste) {

        Optional<Waste> oldWaste = getByID(id);

        if(oldWaste.isPresent()){
            Waste updatedWaste = oldWaste.get();
            updatedWaste.setName(newWaste.getName());
            updatedWaste.setType(newWaste.getType());
            updatedWaste.setWeight(newWaste.getWeight());

            Waste wasteData = wasteRepo.save(updatedWaste);
            return wasteData;
        }
        return null;
    }

    public Waste save(Waste newWaste) {
        Waste savedWaste = wasteRepo.save(newWaste);
        return savedWaste;
    }
}
