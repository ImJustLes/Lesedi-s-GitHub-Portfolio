package com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.service;

import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.model.Waste;
import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.repo.WasteRepo;
import org.springframework.beans.factory.annotation.Autowired;

import java.util.List;
import java.util.Optional;

@org.springframework.stereotype.Service
public class WasteService extends Service<Waste>{

    //Access to Waste table in database.
    @Autowired
    private WasteRepo wasteRepo;

    //Gets all the waste values from the database.
    public List<Waste> getAll() {
        return wasteRepo.findAll();
    }

    //Gets all the waste values, by id, from the database.
    public Optional<Waste> getByID(Long id) {
        return wasteRepo.findById(id);
    }

    //Deletes a waste entry from the database, by id
    public void deleteByID(Long id) {
        wasteRepo.deleteById(id);
    }

    //Updates a waste, by id, with the new waste object information.
    public Waste update(Long id, Waste newWaste) {

        Optional<Waste> oldWaste = getByID(id);

        if(oldWaste.isPresent()){
            Waste updatedWaste = oldWaste.get();

            //Updaing waste information
            updatedWaste.setName(newWaste.getName());
            updatedWaste.setType(newWaste.getType());
            updatedWaste.setWeight(newWaste.getWeight());

            Waste wasteData = wasteRepo.save(updatedWaste);
            return wasteData;
        }
        return null;
    }

    //Saves new waste entry into the database.
    public Waste save(Waste newWaste) {
        Waste savedWaste = wasteRepo.save(newWaste);
        return savedWaste;
    }
}
