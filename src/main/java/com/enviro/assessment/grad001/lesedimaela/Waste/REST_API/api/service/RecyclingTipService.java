package com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.service;

import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.model.RecyclingTip;
import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.repo.RecyclingTipRepo;
import org.springframework.beans.factory.annotation.Autowired;

import java.util.List;
import java.util.Optional;

@org.springframework.stereotype.Service
public class RecyclingTipService extends Service<RecyclingTip>{

    //Gets repo to make to perform CRUD operations
    @Autowired
    private RecyclingTipRepo recyclingTipRepo;

    //Gets all Recyvling tips from the database.
    public List<RecyclingTip> getAll() {
        return recyclingTipRepo.findAll();
    }

    //Gets the recycling tip, by id, from the database.
    public Optional<RecyclingTip> getByID(Long id) {
        return recyclingTipRepo.findById(id);
    }

    //Deletes the recycling tip, by id, from the database.
    public void deleteByID(Long id) {

        recyclingTipRepo.deleteById(id);
    }

    //Updates the tip, by id, with the new tip information into the databse.
    public RecyclingTip update(Long id, RecyclingTip newTip) {

        Optional<RecyclingTip> oldTip = getByID(id);

        if (oldTip.isPresent()) {

            //Making the type of the tip lower case for input sanitisation
            newTip.setType(newTip.getType().toLowerCase());
            RecyclingTip updatedTip = oldTip.get();

            //Replacing the old tip info with the new tip info.
            updatedTip.setTip(newTip.getTip());
            updatedTip.setType(newTip.getType());

            RecyclingTip tipData = recyclingTipRepo.save(updatedTip);

            return tipData;
        }
        return null;
    }

    //Saves the recycling tip into the database.
    public RecyclingTip save(RecyclingTip newTip) {

        //Making the type of the tip lower case for input sanitisation
        newTip.setType(newTip.getType().toLowerCase());

        RecyclingTip tipData = recyclingTipRepo.save(newTip);
        return tipData;
    }
}
