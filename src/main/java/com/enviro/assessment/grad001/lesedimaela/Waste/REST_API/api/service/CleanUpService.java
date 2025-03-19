package com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.service;

import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.model.CleanUp;
import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.repo.CleanUpRepo;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class CleanUpService extends com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.service.Service<CleanUp> {

    //Gets the repo for the Clean Up
    @Autowired
    private CleanUpRepo cleanUpRepo;

    //Gets all Clean ups from the database.
    public List<CleanUp> getAll(){

        return cleanUpRepo.findAll();
    }

    //Gets clean ups, by id, from the database.
    public Optional<CleanUp> getByID(Long id){

        return cleanUpRepo.findById(id);
    }

    //Deletes the clean up, by id, from the database.
    public void deleteByID(Long id){

        cleanUpRepo.deleteById(id);
    }

    //Updates the clean, by id, with the new clean up information.
    public CleanUp update(Long id, CleanUp newCleanUp) {

        Optional<CleanUp> oldCleanUp = getByID(id);

        if (oldCleanUp.isPresent()) {

            //If the new amount of junk is greater than the old amount, you can enter the if statement.
            if (newCleanUp.getCollectedJunk() > oldCleanUp.get().getCollectedJunk()) {
                
                CleanUp updatedCleanup = oldCleanUp.get();

                //Input sanitisation for locations
                newCleanUp.setLocation(newCleanUp.getLocation().toLowerCase());
                
                //Updating with the new clean up information.
                updatedCleanup.setLocation(newCleanUp.getLocation());
                updatedCleanup.setDescription(newCleanUp.getDescription());
                updatedCleanup.setTotalJunk(newCleanUp.getTotalJunk());
                updatedCleanup.setCollectedJunk(newCleanUp.getCollectedJunk());

                CleanUp cleanUpData = save(updatedCleanup);

                return cleanUpData;
            }
        }
        return null;
    }

    //Saves the new clean up information into the database.
    public CleanUp save(CleanUp cleanUp){

        //Input sanitisation for locations
        cleanUp.setLocation(cleanUp.getLocation().toLowerCase());
        CleanUp cleanUpData = cleanUpRepo.save(cleanUp);

        return cleanUpData;
    }
}
